   M S B A M L   `   `   `  ���� K  GPanuon.UI.Silver, Version=1.1.3.4, Culture=neutral, PublicKeyToken=nullM8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.SilverPanuon.UI.Silver  F BNetworkTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:NetworkTool.View.PagesNetworkTool.View.Pages =#clr-namespace:NetworkTool.ViewModelNetworkTool.ViewModel '   !NetworkTool.View.Pages.PortalPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Gpu8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.Silver     6local$clr-namespace:NetworkTool.View.Pages     2vm#clr-namespace:NetworkTool.ViewModel       N� Title$  
PortalPage�� � DataContext + %NetworkTool.ViewModel.PortalViewModel  .����    SecundaryBackgroundColor#���    �� CornerRadius �� *PortalModel.CornerRadius+._��  � RowDefinitions �� $��* ��� $��* ��� $��* �.+��� $��0��$��	传送门��$��40(�$
��Bold"�
�������$��Bottom=�$��Center=�� $��1�� � ColumnDefinitions �� $��* ��� $
��auto �.+��� -   $��0��$��50��$��	100 0 0 0q�$   Panuon.UI.Silver.TextBoxHelper   Header$ http://��   IsClearButtonVisible .    	Watermark$> 8校园网认证IP地址（必填） 例如：10.0.251.18��   CornerRadius$ 3������ *PortalModel.CampusURL+.���� $��1��$��50��$	��100��$��
10 0 100 0q�$
��Open�����#5b7fff#   Panuon.UI.Silver.ButtonHelper	   ButtonStyle$	 Standard=�
   
HoverBrush
 �#4153a2   CornerRadius$ 3��   
ClickStyle$
 Sink=����� *OpenURLCommand+�� $��2��$3��-朝辞白帝彩云间，千里江陵一日还��
���   �$��18(�$	��Top=�$��Center=�