using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Facade.Classes;

// Подсистема: Видео
public class VideoSystem
{
    public void PlayVideo()
    {
        Console.WriteLine("Видео воспроизводится.");
    }

    public void StopVideo()
    {
        Console.WriteLine("Видео остановлено.");
    }
}