   M S B A M L   `   `   `  ���� F  BNetworkTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NetworkToolNetworkTool  =#clr-namespace:NetworkTool.ViewModelNetworkTool.ViewModel      NetworkTool.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:NetworkTool     2vm#clr-namespace:NetworkTool.ViewModel     -   $
��home��  � Title$  MainView��$	��600��$	��850�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�
������  � AllowsTransparency .    MainViewModel � DataContext# �    � 
ResizeMode$ NoResize=� � WindowState$ Normal=�.���� -     PrimaryBackgroundColor#���   �� CornerRadius �� *MainModel.CornerRadius+._��  � ColumnDefinitions �� $
��Auto ��� .+��� $ 8 0 0 8��  SecundaryBackgroundColor#���  ._�� -   	 �Name$	 gridMenu��$��60��
 � RowDefinitions
 �� $��60 ��� $��80 ��� $
��Auto ��� .+��� $��1�� �� Orientation$ 
Horizontal=�$	��Top=�.+�F�   logo#���  $��16 0 0 0q� �� Stretch$
 Fill=�  PrimaryBlueColor#���  $��25��$��25��$
��Left=��� $��200 OK��#���  $
��Bold"�$��20(�$��Center=�$
��Left=�$
��Left=�$��14 0 0 0q�d� -    d�Name$ btnMenu��$��Right=�$��0q�
������ $��Center=�  MenuIconStyle#��[ $��0 0 15 0q� � Triggers :�  :� RoutedEvent$ ToggleButton.Unchecked��.[��� .���� -    ��Name$ HideStackPanel��.��W�  �� 
TargetName$ gridMenu�� �� TargetProperty$ Width� g� 	BeginTime$ 0:0:0X� W� From$	 200X�	 W� To$ 60X� g� Duration$ 0:0:0.1D�:� $ ToggleButton.Checked��.[��� .���� -   $ ShowStackPanel��.��W� $ gridMenu��$ Width�$ 0:0:0X�$ 60X�$	 200X�$ 0:0:0.1D��� $��3��.+�	� -    	�Name$ 	rdWelcome�� d� 	IsChecked$
 TrueY�$��网络连接��  MenuRadioButtonStyle#���    welcome
 � Tag# �  	� -   $ rdPortal��$��	传送门��#���   
 portal# �  $��0 5 0 5q�	� -	   $ 	rdRequest��$��参数设置��#���   	 request# � 	 	� -
   $ 	rdSetting��$��偏好设置��#���   
 setting# � 
 $��0 5 0 5q�	� -   $ rdDeveloper��$��	开发者��#���    	developer# �  $��0 5 0 5q��� $��3��$��Bottom=�$ 
Horizontal=�$	��200��$��0 0 0 20q�.+�A� -    A�Name$ Status��$��25��$��25��$��	16 0 15 0q����� *MainModel.StatusColor+�� -    ��Name$ StatusLabel��$��14(�$��Regular"�$��Center=�$
��Left=����� *MainModel.StatusDescription+� $��1��
 �� $��60 ��� .+��� $��0��$��4��$��Right=�$	��Top=�$��0,5,10,0q�$��30��$ 
Horizontal=�$��RightToLeft=�.+��� -    ��Name$ btnClose��  IconButtonsStyle#��[  	 close#���  $ IsCloseButton���� -   $ 
btnRestore��$	��5,0q�����  �� 
TargetType" �� �� BasedOn# [ .���  �� Property � ��  maximize  �� Value#  �  ! �� Triggers! �� " �� Binding" �� # �� ElementName$
# home��$ �� Path$$ WindowState�% �� Value% 	Maximized.a���  � ��  restore#  �  �� -   $ btnMinimize��#���    minimize#���  �� $��1��$��10q�._� � -   &  �Name$& PagesNavigation��'  � NavigationUIVisibility$' Hidden=�