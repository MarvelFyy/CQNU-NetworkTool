   M S B A M L   `   `   `  ���� K  GPanuon.UI.Silver, Version=1.1.3.4, Culture=neutral, PublicKeyToken=nullM8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.SilverPanuon.UI.Silver  F BNetworkTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:NetworkTool.View.PagesNetworkTool.View.Pages =#clr-namespace:NetworkTool.ViewModelNetworkTool.ViewModel (   "NetworkTool.View.Pages.RequestPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Gpu8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.Silver     6local$clr-namespace:NetworkTool.View.Pages     2vm#clr-namespace:NetworkTool.ViewModel     -   $��RequestPageView��  N� Title$  RequestPage�� � DataContext , &NetworkTool.ViewModel.RequestViewModel  .����    SecundaryBackgroundColor#���   
������� �� CornerRadius �� *RequestModel.CornerRadius+._��  � RowDefinitions �� $
��auto ��� $��* ��� $
��auto ��� $��2* ��� $
��auto ��� $��2* ��� $��* �.+��� $��0��$��Request URL��$��12(��� $��1��$	��5,0q� �� TextWrapping$
 Wrap=� �� AcceptsReturn . $   Panuon.UI.Silver.TextBoxHelper   	Watermark$ 请求URL（必填）��   CornerRadius$ 0��   IsClearButtonVisible . ���� *RequestModel.URL+�� $��2��$��Request Headers��$��12(��� $��3��$	��5,0q�$
 Wrap=� . 	 �� TextAlignment$
	 Left=�$ 请求标头（必填）��$ 0�� . ���� *RequestModel.Header+�� $��4��$��	Form Data��$��12(��� $��5��$	��5,0q�$
 Wrap=� . $ 表单数据（必填）��$ 0�� . ���� *RequestModel.Data+�� $��6��$��Center=�$��40��$	��100�����#5b7fff$��保存��#   Panuon.UI.Silver.ButtonHelper
   ButtonStyle$
 Standard=�   
HoverBrush �#4153a2   
ClickStyle$
 Sink=�   CornerRadius$ 3������ *SaveRequestCommand+����  �� ElementName$ RequestPageView��