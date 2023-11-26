using SixLabors.ImageSharp.Formats.Webp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database.Helpers
{
    public static class ImageWorker
    {
        /// <summary>
        /// Збереження фото в папку
        /// </summary>
        /// <param name="url">Адреса фото в мережі</param>
        /// <returns>Повертаємо назву фото</returns>
        public static string ImageSave(string url, string imageName=null)
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(url).Result;
                    if(response.IsSuccessStatusCode)
                    {
                        //список байт фото
                        byte[] imageBytes = response.Content.ReadAsByteArrayAsync().Result;
                        int size = 1200; //розмір фото, яке буде зберігатися
                        //Рандомна величина, яка не може повторится при генерації
                        string fileName = imageName ?? Guid.NewGuid().ToString() + ".webp";
                        var dir = Path.Combine(Directory.GetCurrentDirectory(), "images");
                        if(!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }
                        var outPath = Path.Combine(dir, fileName);
                        using (var image = Image.Load(imageBytes))
                        {
                            image.Mutate(x =>
                            {
                                x.Resize(new ResizeOptions
                                {
                                    Size = new Size(size, size),
                                    Mode = ResizeMode.Max
                                });
                            });
                            using (var ms = new MemoryStream())
                            {
                                image.Save(ms, new WebpEncoder());
                                var bytesOut = ms.ToArray();
                                File.WriteAllBytes(outPath, bytesOut);
                                return fileName;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Запит по фото пройшов із проблемой {0}", response.StatusCode);
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Помилка збереження фото {0}", ex.Message);
            }
            return null;
        }
    }
}
