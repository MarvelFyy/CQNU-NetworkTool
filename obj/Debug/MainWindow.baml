   M S B A M L   `   `   `  ����F  BNetworkTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NetworkToolNetworkTool  5   	   =#clr-namespace:NetworkTool.ViewModelNetworkTool.ViewModel  5   	       NetworkTool.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:NetworkTool     5   	   2vm#clr-namespace:NetworkTool.ViewModel     5   	   -   5        $
��home��5        � Title$  MainView��5	   	   $	��600��6   $	��850��6'    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency .    MainViewModel � DataContext# �   5   	    � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   .��5      �� -   5          PrimaryBackgroundColor#���  5   o    �� CornerRadius 6   �� *MainModel.CornerRadius+._�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $ 8 0 0 8��6     SecundaryBackgroundColor#���  6,   ._�5      � -   5        	 �Name$	 gridMenu��5      $��60��6)   
 � RowDefinitions
 5      �� 5      $��60 �6(   �� 5      $��80 �6(   �� 5      $
��Auto �6(   �� 5      .+�5      �� $��1��6!    �� Orientation$ 
Horizontal=�6.   $	��Top=�6G   .+�5       F�   logo#���  6   $��16 0 0 0q�6=    �� Stretch$
 Fill=�6O     PrimaryBlueColor#���  6^   $��25��6�   $��25��6�   $
��Left=�6�   �� 5!      $��200 OK��6    #���  61   $
��Bold"�6a   $��20(�6s   $��Center=�6�   $
��Left=�6�   $
��Left=�6�   $��14 0 0 0q�6�   5"      d� 5%      -   5         d�Name$ btnMenu��5%   #   $��Right=�65   $��0q�6Q   
������ $��Center=�6~     MenuIconStyle#��[ 6�   $��0 0 15 0q�6�    � Triggers 5&      :� 5'       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5(   "   �� .��5)   &   �� -   5         ��Name$ HideStackPanel��5)   1   .��5*   *   W�  �� 
TargetName$ gridMenu��6:    �� TargetProperty$ Width�6[    g� 	BeginTime$ 0:0:0X�6}    W� From$	 200X�6�   	 W� To$ 60X�6�    g� Duration$ 0:0:0.1D�6�   5+   +   5,   '   5-   #   5.      :� 5/      $ ToggleButton.Checked��6+   .[�50   "   �� .��51   &   �� -   5        $ ShowStackPanel��51   1   .��52   *   W� $ gridMenu��6:   $ Width�6[   $ 0:0:0X�6}   $ 60X�6�   $	 200X�6�   $ 0:0:0.1D�6�   53   +   54   '   55   #   56      58      �� 5:      $��3��6!   .+�5;      	� -   5         	�Name$ 	rdWelcome��5;   &    d� 	IsChecked$
 TrueY�69   $��网络连接��6J     MenuRadioButtonStyle#���  6Y     welcome
 � Tag# �  6�   6�   	� 5<      -   5        $ rdPortal��5<   &   $��	传送门��68   #���  6F    
 portal# �  6u   $��0 5 0 5q�6�   6�   	� 5=      -	   5        $ 	rdRequest��5=   &   $��参数设置��69   #���  6H    	 request# � 	 6w   6�   	� 5>      -
   5        $ 	rdSetting��5>   &   $��偏好设置��69   #���  6H    
 setting# � 
 6w   $��0 5 0 5q�6�   6�   	� 5?      -   5        $ rdDeveloper��5?   &   $��	开发者��6;   #���  6I     	developer# �  6x   $��0 5 0 5q�6�   6�   5@      �� 5B      $��3��6!   $��Bottom=�6.   $ 
Horizontal=�6I   $	��200��6b   $��0 0 0 20q�6n   .+�5C      A� -   5         A�Name$ Status��5C   "   $��25��62   $��25��6=   $��	16 0 15 0q�6I   ��6\   �� *MainModel.StatusColor+5L      �� 5M      -   5         ��Name$ StatusLabel��5M   P   $��14(�6f   $��Regular"�6t   $��Center=�6�   $
��Left=�6�   ��6    �� *MainModel.StatusDescription+6�   5N      5O      5P      � 5T      $��1��6   
 5U      �� 5V      $��60 �6$   �� 5W      .+�5[      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�   $ 
Horizontal=�6�   $��RightToLeft=�6�   .+�5\      �� -   5         ��Name$ btnClose��5\        IconButtonsStyle#��[ 6/    	 close#���  6Y   $ IsCloseButton��6�   �� 5]      -   5        $ 
btnRestore��5]      $	��5,0q�61   ��5^      �� 5_       �� 
TargetType" ��6$    �� BasedOn# [ 6A   .�5`   "   ��  �� Property � ��  maximize  �� Value#  �  6<   ! �� Triggers! 5a   "   �� 5b   &   " �� Binding" 62   �� # �� ElementName$
# home��$ �� Path$$ WindowState�% �� Value% 	Maximized6i   .a�5c   *   ��  � ��  restore#  �  6D   5d   '   5f      5h      �� 5i      -   5        $ btnMinimize��5i      #���  62     minimize#���  6]   6�   5j      �� 5m      $��1��6   $��10q�6&   ._�5n       � -   5        &  �Name$& PagesNavigation��5n      '  � NavigationUIVisibility$' Hidden=�65   5p      5q      5r      5t      5u      5v      