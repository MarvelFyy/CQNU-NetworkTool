   M S B A M L   `   `   `  ���� K  GPanuon.UI.Silver, Version=1.1.3.4, Culture=neutral, PublicKeyToken=nullM8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.SilverPanuon.UI.Silver  F BNetworkTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:NetworkTool.PropertiesNetworkTool.Properties ?$clr-namespace:NetworkTool.View.PagesNetworkTool.View.Pages =#clr-namespace:NetworkTool.ViewModelNetworkTool.ViewModel (   "NetworkTool.View.Pages.SettingPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Gpu8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.Silver     ;
Properties$clr-namespace:NetworkTool.Properties     6local$clr-namespace:NetworkTool.View.Pages     2vm#clr-namespace:NetworkTool.ViewModel       N� Title$  	NotesPage�� � DataContext , &NetworkTool.ViewModel.SettingViewModel  .����    SecundaryBackgroundColor#���    �� CornerRadius �� *SettingModel.CornerRadius+._��  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��基本设置��$��5q�$��18(���  �� Orientation$ 
Horizontal=�$��1��.+��� -    ��Name$ Boot_CheckBox��$��25 5 0 5q�%   Panuon.UI.Silver.CheckBoxHelper   HeaderWidth$ *��   CheckedBackground �#5b7fff   CheckBoxStyle$ Switch=�	 d� 	IsChecked	 �� *SettingModel.Boot+���� *BootWithSystemCommand+���� 
 �� RelativeSource
 �� *self+�� $��开机启动程序��$��14(�$	��0 5q��� $ 
Horizontal=�$��2��.+��� -   $ Link_CheckBox��$��25 5 0 5q�$ *�� �#5b7fff$ Switch=�	 �� *SettingModel.Link+���� *AutoLinkCommand+���� 
 �� *self+�� $!��开机自动连接校园网��$��14(�$	��0 5q��� $ 
Horizontal=�$��3��.+��� -   $ Shortcut_CheckBox��$��25 5 0 5q�$ *�� �#5b7fff$ Switch=�	 �� *SettingModel.Shortcut+���� *CreateShotcutCommand+���� 
 �� *self+�� $��创建桌面快捷方式��$��14(�$	��0 5q��� $ 
Horizontal=�$��4��.+��� -   $ Corner_CheckBox��$��25 5 0 5q�$ *�� �#5b7fff$ Switch=�	 �� *SettingModel.Corner+���� *SetCornerCommand+���� 
 �� *self+�� $*��$Windows11风格（窗体圆角化）��$��14(�$	��0 5q��� $��5��$��关于应用��$��5q�$��18(��� $��6��$��版本号 V.0.1.5��$��25 5 0 5q�$��14(�