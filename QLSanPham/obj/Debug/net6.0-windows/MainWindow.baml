   M S B A M L   `   `   `  ????D  @QLSanPham, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLSanPham	QLSanPham  5   	       QLSanPham.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:QLSanPham     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5      ? .+?5   
   ?? $??Mã sản phầm??6   $
??Left=?6&   $??	62,61,0,0q?6A   $	??Top=?6T   ?? 5   
   $??Tên sản phẩm??6   $
??Left=?6'   $??	62,92,0,0q?6B   $	??Top=?6U   ?? 5   
   $??Số lượng??6   $
??Left=?6#   $??
61,123,0,0q?6>   $	??Top=?6R   ?? 5   
   $??
Đơn giá??6   $
??Left=?6"   $??
61,154,0,0q?6=   $	??Top=?6Q   ?? 5   
   $??
Mã loại??6   $
??Left=?6"   $??
61,187,0,0q?6=   $	??Top=?6Q   ?? 5   
   -   5         ??Name$ txtmasanpham??5      $
??Left=?6(   $??
177,65,0,0q?6C    ?? TextWrapping$
 Wrap=?6W   $	??Top=?6k   $	??183??6?   $??22??6?   ?? 5   
   -   5        $ txttensanpham??5      $
??Left=?6)   $??
177,96,0,0q?6D   $
 Wrap=?6X   $	??Top=?6l   $	??183??6?   $??22??6?   ?? 5   
   -   5        $ 
txtsoluong??5      $
??Left=?6&   $??177,127,0,0q?6A   $
 Wrap=?6V   $	??Top=?6j   $	??183??6?   $??22??6?   ?? 5   
   -   5        $ 	txtdongia??5      $
??Left=?6%   $??177,158,0,0q?6@   $
 Wrap=?6U   $	??Top=?6i   $	??183??6?   $??22??6?   ?? 5   
   -   5        $ 	txtmaloai??5      $
??Left=?6%   $??177,189,0,0q?6@   $
 Wrap=?6U   $	??Top=?6i   $	??183??6?   $??22??6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgrid??5      $??400,61,40,31q?6#      AutoGenerateColumns$ False??69      CanUserAddRows$ False??5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *	Masanpham+  5      $ Tên sản phẩm??6%    6;   ?? *
Tensanpham+  5      $ Số lượng??6%    67   ?? *	Soluong+  5      $ 
Đơn giá??6%    66   ?? *Dongia+  5      	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6%   $ 
Mã loại??6/    6@   ?? *Maloai+5      ?? 5    
   -   5        
 ??Name$
 btthem??5       $??Thêm ??6!   $
??Left=?61   $??
32,274,0,0q?6L   $	??Top=?6`   $??54??6x   6?   ?? 5!   
   -	   5        $
 btsua??5!      $??Sửa??6    $
??Left=?6.   $??137,274,0,0q?6I   $	??Top=?6^   $??54??6v   6?   ?? 5"   
   -
   5        $
 btxoa??5"      $
??Xóa??6    $
??Left=?6.   $??250,274,0,0q?6I   $	??Top=?6^   $??54??6v   6?   ?? 5#   
   $(??"QUẢN LÝ DANH MỤC SẢN PHẨM??6   $??Center=?64   $??0,10,0,0q?6Q   $	??Top=?6c   5%      5&      