   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:NavigationDrawerPopUpMenu2NavigationDrawerPopUpMenu2  5   	   +    %NavigationDrawerPopUpMenu2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:NavigationDrawerPopUpMenu2     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5   	   $
��1080��6   $	��600��5	      $
��1080��6'   ���#000000  � 
ResizeMode$  NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_    � WindowStyle$
 None=�6�    � WindowState$ 	Maximized=�6�    � 	Resources 5
         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.1��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.1��6'   $ 70Q�69   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5!      � ���#edeff3.+�5"   
   � -   5         �Name$ GridMain��5"      � 5#   
   -   5        $ GridMenu��5#      $��70��6!   $
��Left=�6,   ��5$      �� 5%       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5&      �  � Color$ #68EAD0��6#    � Offset$ 0Q�63   � 5'      $ #59C5E1��6#   $ 1Q�63   5(       J� Effect 5*      3  -System.Windows.Media.Effects.DropShadowEffect  5+         
BlurRadius$ 2Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFAEAEAE��6B      Opacity$	 0.2Q�6T   .+�5-      �� .+�5.      � $��60��6   
������  J� RenderTransformOrigin$ 0.5,0.5&�6<   z�5/      V� 50      .~�51      �� �� 52      �� 53      T� 54      55      .+�57      �� -   5         ��Name$ ButtonOpenMenu��57      $��60��65   $��60��6A   $��5q�6L   $��Right=�6W   $	��Top=�6s    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���#FFFFFF��6�   Z� ��6�   Z� .��58      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�62   $��25��6>   $��25��6I   59      �� 5:      -   5        $ ButtonCloseMenu��5:      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5;        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5<      5>      �� 5?      -   5         ��Name$ ListViewMenu��5?      ���#FFFFFF$
��Auto=�6F   $��Disabled=�6v   .@�5@      �� -   5         ��Name$ dashboardHome��5@   #   $��60��6:   .��5A      ��  �� Orientation$ 
Horizontal=�6%   .+�5B        $
 Home=�66   $��25��6B   $��25��6N   $��10q�6Y   5C      �� 5D      $
��Home��6(   $��Center=�64   $��10 10q�6O   5E      5F      �� 5G      -   5        $ manageUsers��5G   #   $��60��68   .��5H      �� $ 
Horizontal=�6%   .+�5I        $ Account=�66   $��25��6E   $��25��6Q   $��10q�6\   �� 5J      $��Manage Accounts��6(   $��Center=�6?   $��10 10q�6Z   5K      5L      �� 5M      -   5        $ salesInventory��5M   #   $��60��6;   .��5N      �� $ 
Horizontal=�6%   .+�5O        $
 Coin=�66   $��25��6B   $��25��6N   $��10q�6Y   �� 5P      $��Sales Inventory��6(   $��Center=�6?   $��10 10q�6Z   5Q      5R      �� 5S      -	   5        $ inventoryStocks��5S   #   $��60��6<   .��5T      �� $ 
Horizontal=�6%   .+�5U        $ Store=�66   $��25��6C   $��25��6O   $��10q�6Z   �� 5V      $��Storage Stocks��6(   $��Center=�6>   $��10 10q�6Z   5W      5X      �� 5Y      -
   5        $ posSettings��5Y   #   $��60��68   .��5Z      �� $ 
Horizontal=�6%   .+�5[        $
 Sale=�66   $��25��6B   $��25��6N   $��10q�6Y   �� 5\      $��Discount Settings��6(   $��Center=�6A   $��10 10q�6]   5]      5^      �� 5_      -   5        $ categoryButton��5_   #   $��60��6;   .��5`      �� $ 
Horizontal=�6%   .+�5a        $	 Tag=�66   $��25��6A   $��25��6M   $��10q�6X   �� 5b      $��Category��6(   $��Center=�68   $��10 10q�6T   5c      5d      �� 5e      -   5        $ stockInButton��5e   #   $��60��6:   .��5f      �� $ 
Horizontal=�6%   .+�5g        $ Shopping=�66   $��25��6F   $��25��6R   $��10q�6]   �� 5h      $��Stocks Inventory��6(   $��Center=�6@   $��10 10q�6\   5i      5j      �� 5k      -   5        $ settingsButton��5k   #   $��60��6;   .��5l      �� $ 
Horizontal=�6%   .+�5m        $ Settings=�66   $��25��6F   $��25��6R   $��10q�6]   �� 5n      $��Settings��6(   $��Center=�68   $��10 10q�6T   5o      5p      �� 5q      -   5        $ logoutButton��5q   #   $��60��69   .��5r      �� $ 
Horizontal=�6%   .+�5s        $ LogoutVariant=�66   $��25��6K   $��25��6W   $��10q�6b   �� 5t      $��Logout��6(   $��Center=�66   $��10 10q�6R   5u      5v      5w      5x      5y      5z      5|      