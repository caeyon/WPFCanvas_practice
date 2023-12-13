using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCanvas_practice;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    CanvasViewModel viewModel = new CanvasViewModel();
    private Boolean IsMoving = false;
    private Image? MovingImage = null;
    private Point Diff = new Point(0, 0);

    public MainWindow()
    {
        InitializeComponent();

        DataContext = viewModel;
    }

    private void OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        MovingImage = (Image)sender;
        Diff = e.GetPosition(MovingImage);
        IsMoving = true;
    }

    private void OnMouseUp(object sender, MouseButtonEventArgs e)
    {
        MovingImage = null;
        IsMoving = false;
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        //MessageBox.Show("마우스 버튼 클릭");
        if (!IsMoving)
            return;

        //viewModel.SetPos(e.GetPosition(this));

        Point p = new Point(
            e.GetPosition(this).X + Center.RADIUS - Diff.X,
            e.GetPosition(this).Y + Center.RADIUS - Diff.Y);

        switch(MovingImage?.Name)
        {
            case "Zudah":
                //viewModel.Zudah = e.GetPosition(this);
                viewModel.Zudah = p;
                break;
            case "Kampfer":
                //viewModel.Kampfer = e.GetPosition(this);
                viewModel.Kampfer = p;
                break;
            default:
                break;
        }
    }
}
