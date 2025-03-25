using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Facade.Classes;

// Фасад для упрощения работы с подсистемами
public class VideoPlayerFacade
{
    private readonly AudioSystem _audioSystem;
    private readonly VideoSystem _videoSystem;

    public VideoPlayerFacade()
    {
        _audioSystem = new AudioSystem();
        _videoSystem = new VideoSystem();
    }

    public void PlayMovie()
    {
        Console.WriteLine("Начинаем просмотр фильма...");
        _audioSystem.TurnOn();
        _videoSystem.PlayVideo();
    }

    public void StopMovie()
    {
        Console.WriteLine("Завершаем просмотр фильма...");
        _videoSystem.StopVideo();
        _audioSystem.TurnOff();
    }
}