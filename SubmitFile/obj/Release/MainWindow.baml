   M S B A M L   `   `   `  ���� E  ASubmitFile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  Y1clr-namespace:MaterialDesignThemes.Wpf.Converters#MaterialDesignThemes.Wpf.Converters  'clr-namespace:SubmitFile
SubmitFile      SubmitFile.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  0wpf&clr-namespace:MaterialDesignThemes.Wpf  B
converters1clr-namespace:MaterialDesignThemes.Wpf.Converters  $localclr-namespace:SubmitFile  -     � Title$  Quản lý tài liệu��$	��650��$
��1000�� � WindowStartupLocation$ CenterScreen=� � Icon$ resource\manager.png�� � 	Resources  �� MergedDictionaries �� Source��  �� $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?��� $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Card.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?��� $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Flipper.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Popupbox.xaml?�%    .���  � RowDefinitions �� �� $��30 � � ColumnDefinitions �� $	��200 ��� .+��� $
��Left=�$	��200�����	#FFB7E5F0$��0��$��0��$��2��$	��620��$	��Top=�.+�&   MaterialDesignThemes.Wpf.Flipper     MaterialDesignCardFlipper#��[     FrontContent � $	��350��$	��200�� �� $	��160 ��� $��* �.+�(  "MaterialDesignThemes.Wpf.ColorZone  	   Mode$	 PrimaryLight=�$��Stretch=�.��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]
   Kind$
 AccountCircle=�$	��128��$	��128��$��Center=�$��Center=��� $��1��$��Center=�$��Center=�.+��� -    ��Name$ 
lbFullName��$��20(�$��5,5,5,0q���   MaterialDesignFlatButton#��[    FlipCommand#��Z $��0 4 0 0q�.��Sửa thông tin�� -    ��Name$ btnDangXuat��#��[ $��0 4 0 0q�.��Đăng xuất   BackContent � $��5q�$	��200�� �� $
��Auto ��� $��* �.+�  $	 Accent=�$��6q�.����  �� Orientation$ 
Horizontal=�.+���  & "MaterialDesignToolForegroundButton#��[ #��Z $
��Left=�.��  $
 	ArrowLeft=�$��Right=��� $��8 0 0 0q�$��Center=�Sửa thông tin� $��1��$��0 6 0 0q�$��Center=�$	��Top=�$	��172�� �� �� �� �� �� �� .+��� -    ��Name$ 	txtTenDau��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đầu��   
IsFloating . $��0 12 0 0q�.���� -   $ 
txtTenCuoi��$��1��$ Tên cuối�� . $��0 12 0 0q�.��G� -    G�Name$ 	txtPassCu��$��2��$ Mật khẩu cũ�� . $��0 12 0 0q�G� -   $ 
txtPassMoi��$��3��$ Mật khẩu mới�� . $��0 12 0 0q�G� -   $ 
txtXacNhan��$��4��$ Xác nhận�� . $��0 12 0 0q��� $��5��#��[ #��Z $��0 4 0 0q�.��Cập nhật�� $��1��$��1��$ 
Horizontal=�.+��� -	   $ txtChonFile�����	#FFB7E5F0$	��500��$��5,0,5,5q� J� 	AllowDrop . .���� -
   $ 
btnChonTep��$	��125��$��40��$��10,0,5,5q�$��18(�$��Center=�.��Chọn tệp�� -   $ 
btnThemTep��$	��125��$��40��$��5,0,10,5q�$��Right=�$��18(�$��Center=�.��Thêm tệp�� -   $��lstvFicheiros��$��0,40,0,0q�$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��1��$��0�� .  � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��contexMenuDown��$��Download��m� -   $��contextMenuRemove��$��Remove�� �� View �� P���  �� Width$ 32�� �� CellTemplate �� .R���  J� 
RenderSize$ 32,32������ *
FileIcon+�� $��
Tên tệp�� �� DisplayMemberBinding �� *
FileName+