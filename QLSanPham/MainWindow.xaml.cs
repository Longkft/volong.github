using QLSanPham.Models;
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
using System.Xml.Linq;


namespace QLSanPham
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        QlspContext db = new QlspContext();
        private void hienThi(object sender, RoutedEventArgs e)
        {
            dthienthi();
        }

        private void dthienthi()
        {
            //Truy vấn LINQ để lấy dữ liệu
            var query = from dmsp in db.Dmsanphams
                        select dmsp;

            //Hiển thị dữ liệu datagrid
            dtgrid.ItemsSource = query.ToList();


        }

        private void clear()
        {
            txtmasanpham.Text = "";
            txttensanpham.Text = "";
            txtsoluong.Text = "";
            txtdongia.Text = "";
            txtmaloai.Text = "";
            txtmasanpham.Focus();
        }
        private void btthem_Click(object sender, RoutedEventArgs e)
        {
            Dmsanpham dm = new Dmsanpham();

            dm.Masanpham = Convert.ToInt32(txtmasanpham.Text);
            dm.Tensanpham = txttensanpham.Text;
            dm.Soluong = Convert.ToInt32(txtsoluong.Text);
            dm.Dongia = double.Parse(txtdongia.Text);
            dm.Maloai = Convert.ToInt32(txtmaloai.Text);

            if (!db.Dmsanphams.Contains(dm))
            {
                db.Dmsanphams.Add(dm);

                db.SaveChanges();

                dthienthi();

                clear();
            }
            else
            {
                MessageBox.Show("Đã có sản phẩm" + txtmasanpham.Text, "Thêm dữ liệu", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void btsua_Click(object sender, RoutedEventArgs e)
        {

            // Lấy ra sản phẩm muốn sửa
            var spsua = (from dmsp in db.Dmsanphams
                         where dmsp.Masanpham == Convert.ToInt32(txtmasanpham.Text)
                         select dmsp).SingleOrDefault();

            if (spsua != null)
            {
                // Cập nhật thông tin sản phầm
                spsua.Tensanpham = txttensanpham.Text;
                spsua.Soluong = Convert.ToInt32(txtsoluong.Text);
                spsua.Dongia = Convert.ToDouble(txtdongia.Text);
                spsua.Maloai = Convert.ToInt32(txtmaloai.Text);

                //lưu thay đổi vào csdl
                db.SaveChanges();
                dthienthi();
                clear();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm mã" + txtmasanpham.Text, "Sửa dữ liệu", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void btxoa_Click(object sender, RoutedEventArgs e)
        {
            var spxoa = (from dmsp in db.Dmsanphams
                         where dmsp.Masanpham == Convert.ToInt32(txtmasanpham.Text)
                         select dmsp).SingleOrDefault();

            if (spxoa != null)
            {
                //Xóa sản phẩm
                db.Dmsanphams.Remove(spxoa);
                //Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();

                dthienthi();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm mã" + txtmasanpham.Text, "Xóa dữ liệu", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
