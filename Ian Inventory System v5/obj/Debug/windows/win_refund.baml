   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:NavigationDrawerPopUpMenu2.windows"NavigationDrawerPopUpMenu2.windows  5   	   3    -NavigationDrawerPopUpMenu2.windows.win_refund   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:NavigationDrawerPopUpMenu2.windows     5   	     � Title$   ��5   	   $	��600��6   $
��1080��6    � 
ResizeMode$ NoResize=�6,    � WindowStartupLocation$ CenterScreen=�6B    � WindowState$ Normal=�6g    � WindowStyle$ SingleBorderWindow=�6|   .��5
      � ���#EDEFF3.+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6   $��4��6#   .+�5      � .+�5      �� $��10q�6     �� RadiusX$ 8��6,    �� RadiusY$ 8��68   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   RenderingBias$	 Quality=�6/   
   Color$
 	#FF838383��6G      Opacity$	 0.2Q�6Y   5      � 5      $��20q�6    � RowDefinitions 5      �� 5      $	��50* �6,   �� 5      $
��420* �6,   .+�5!      � $��0��6   .+�5"      (�  (� Stretch$ Uniform=�6&   $��5q�68   $
��Left=�6C   .��5$   "   ��  �� Orientation$ 
Horizontal=�6-   $��Center=�6F   .+�5%   &   �� -   5         ��Name$ searchTrans��5%   .   $��1q�6C   $��2 0 0 0q�6W   $��Microsoft Tai Le)�6i   $��20(�6�   $	��500��6�   $��Center=�6�   6�   �� 5'   &   -   5         ��Name$ 
itemRefund��5'   -   $��20 10 20 10q�6A   $��30��6V   $	��130��6b   
����������#2C9CDB.��5(   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5)   .   �� $��Refund��68   $��SemiBold"�6F   $��12(�6\   ���#2C9CDB �� TextAlignment$
 Left=�6   $��Center=�6�   5*   +   5+   '   �� 5-   &   -   5        $ itemQuantity��5-   -   $��
0 10 20 10q�6C   $��30��6W   $	��130��6c   
����������#2C9CDB.��5.   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5/   .   �� $��Quantity��68   $��SemiBold"�6H   $��12(�6^   ���#2C9CDB$
 Left=�6�   $��Center=�6�   50   +   51   '   �� 53   &   -   5         ��Name$ slcNo��53   0   $y�Hidden=�6?   $	��100��6S   ��6_   ��  �� ElementName$ 	lv_browse�� �� Path$ SelectedItem.salesNo��� 54   &   -   5        $ slcQty��54   0   $y�Hidden=�6@   $��50��6T   ��6_   �� $ 	lv_browse��$ SelectedItem.salesQty��� 55   &   -   5        $ curQty��55   .   $��50��6>   $y�Hidden=�6I   �� 56   &   -   5        $ refNo��56   .   $y�Hidden=�6=   $��50��6Q   ��6\   �� $ 	lv_browse��$ SelectedItem.refNo�57   #   58      59      � 5;      $��1��6   .+�5<      �� -   5         ��Name$ 	lv_browse��5<   '   $��Stretch=�6:   $��Stretch=�6X    �� SelectionMode$ Single=�6t   $��10q�6�    �� View 5=   "   �� 5>   &    �� AllowsColumnReorder .  P�5?   *   �� 5@   .   $��Ref #��6e    �� Width$	 200��6t    �� DisplayMemberBinding 6=   �� *refNo+6t   �� 5A   .   $��Prod #��6g   $	 200��6w    6=   �� *	salesNo+6w   �� 5B   .   $
��Item��6i   $	 300��6w    6=   �� *	salesItem+6w   �� 5C   .   $	��Qty��6h   $	 100��6u    6=   �� *
salesQty+6u   �� 5D   .   $��Total��6j   $	 100��6y    6=   �� *
salesTotal+6y   �� 5E   .   $��Date of Purchase��6i   $	 300��6�    6=   �� *	salesDate+6�   5G   '   5I      5J      5K      5M      5N      5O      5P      5Q      