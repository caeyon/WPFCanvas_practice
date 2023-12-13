using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCanvas_practice;

public class CanvasViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    //private double _posX;
    //public double PosX { get => _posX; }

    //private double _posY;
    //public double PosY { get => _posY; }

    private System.Windows.Point _zudah;
    public System.Windows.Point Zudah 
    {  
        get => _zudah;
        set
        {
            _zudah = value;
            OnPropertyChanged(nameof(Zudah));
        }
    }

    private System.Windows.Point _kampfer;
    public System.Windows.Point Kampfer
    {
        get => _kampfer;
        set
        {
            _kampfer = value;
            OnPropertyChanged(nameof(Kampfer)); 
        }
    }

    public CanvasViewModel()
    {
        //_posX = 200;
        //_posY = 200;

        _zudah = new System.Windows.Point(400, 200);
        _kampfer = new System.Windows.Point(100, 200);
    }

    //public void SetPos(System.Windows.Point p)
    //{
    //    //_posX = p.X;
    //    //_posY = p.Y;

    //    //OnPropertyChanged(nameof(PosX));
    //    //OnPropertyChanged(nameof(PosY));

    //    _zudah = p;
    //    OnPropertyChanged(nameof(Zudah));
    //}

    private void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
