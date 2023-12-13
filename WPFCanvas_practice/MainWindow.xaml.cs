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
    public MainWindow()
    {
        InitializeComponent();

        DataContext = viewModel;
    }

    private void OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        IsMoving = true;
    }

    private void OnMouseUp(object sender, MouseButtonEventArgs e)
    {
        IsMoving = false;
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        //MessageBox.Show("마우스 버튼 클릭");
        if (!IsMoving)
            return;
        
        viewModel.SetPos(e.GetPosition(this));
    }
}
