   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      A    ;NavigationDrawerPopUpMenu2.usercontrols.usc_sales_inventory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      .��5      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��70 �6   �� 5      $
��150* �6   �� 5      $
��850* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��1��6   $��2��6   .+�5      � ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ #4CA8A5��6'    � Offset$ 0Q�67   � 5      $ #45D5D5��6'   $ 1Q�67   5       5       �� 5!      $	��50* �6$   �� 5"      $
��385* �6$   �� 5#      $��* �6$   .+�5'      � $��0��6   .+�5(      � .+�5)      (�  (� Stretch$ Uniform=�6"   .��5*      �� $��Sales Inventory��6(   $
��Bold"�6?   $��10(�6Q   ���#FFFFFF$��20q�6t    �� TextAlignment$ Center=�6�   5+      5,      5-      � 5/      $��1��6   .+�50      � $��10q�6   .+�51      �� .+�52      (� $ Uniform=�6&   .��53   "   ��  �� Orientation$ Vertical=�6-   .+�55   &   �� $ Vertical=�61   $��Center=�6H   $��Center=�6c   .+�56   *   �� $��Date of Sales (From)��64   $��Center=�6P   ���#FFFFFF$
��Bold"�6�   $��10(�6�   $��0 0 0 5q�6�   (  "System.Windows.Controls.DatePicker  57   *   -   5        	  Name$	 sortCalendarFrom��57   5   $��12(�6O   $��1q�6]   $��10 0 0 0q�6q   $��Microsoft Tai Le)�6�   $��25��6�   $	��130��6�   $��Center=�6�   ���#45D5D5
�������6�   58   '   �� 5;   &   $ Vertical=�61   $��Center=�6H   $��Center=�6c   .+�5<   *   �� $��Date of Sales (To)��64   $��Center=�6N   ���#FFFFFF$
��Bold"�6�   $��10(�6�   $��0 10 0 5q�6�     5=   *   -   5        $	 sortCalendarTo��5=   5   $��12(�6�   $��1q�6�   $��10 0 0 0q�6�   $��Microsoft Tai Le)�6�   $��25��6�   $	��130��6  $��Center=�6  ���#45D5D5
�������
   Text
 6M   ��  �� Today �� Source# Z  �� StringFormat$ {0:yyyy MM, dd}��6A  5>   '   �� 5A   &   $ Vertical=�61   $��Center=�6H   $��Center=�6c   .+�5B   *   �� $��Brand��64   $��Center=�6A   ���#FFFFFF$
��Bold"�6s   $��10(�6�   $��0 10 0 5q�6�   �� 5C   *   -   5         ��Name$ 	sortBrand��5C   3   $��1q�6F   $��5q�6Z   $��Microsoft Tai Le)�6f   $��10(�6�   $��25��6�   $	��130��6�   $��Center=�6�   ���#45D5D5
������� �� 
IsEditable . .@�5D   .   �� $��Select��6;    �� 
IsSelected . 6L   5E   +   5F   '   �� 5I   &   $ Vertical=�61   $��Center=�6H   $��Center=�6c   .+�5J   *   �� $��Category��64   $��Center=�6D   $
��Bold"�6a   ���#FFFFFF$��10(�6�   $��0 10 0 5q�6�   �� 5K   *   -   5        $ sortCategory��5K   3   $��1q�6I   $��5q�6]   $��Microsoft Tai Le)�6i   $��10(�6�   $��25��6�   $	��130��6�   $��Center=�6�   ���#45D5D5
������� . .@�5L   .   �� $��Select��6;    . 6L   5M   +   5N   '   �� 5Q   &   $ Vertical=�61   $��Center=�6H   $��Center=�6c   .+�5R   *   �� $��Status��64   $��Center=�6B   $
��Bold"�6_   ���#FFFFFF$��10(�6�   $��0 10 0 5q�6�   �� 5S   *   -   5        $ 
sortStatus��5S   3   $��1q�6G   $��5q�6[   $��Microsoft Tai Le)�6g   $��10(�6�   $��25��6�   $	��130��6�   $��Center=�6�   ���#45D5D5
������� . .@�5T   .   �� $��Select��6;    . 6L   �� 5U   .   $
��Sold��6;   �� 5V   .   $��	Cancelled��6;   �� 5W   .   $��Pending��6;   5X   +   5Y   '   �� 5[   &   $��Stretch=�60   $��Stretch=�6L   ���#FFFFFF$��20 20 20 10q�6{   �� 5^   &   -   5         ��Name$ 
sortButton��5^   -   $��	5 10 5 10q�6A   $��30��6T   $	��130��6`   
����������#b2b2b2.��5_   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5`   .   �� $��Filter��68   $��SemiBold"�6F   $��12(�6\   
���   �$
 Left=�6}   $��Center=�6�   5a   +   5b   '   �� 5e   &   -   5        $ refreshItem��5e   -   $��5 0 5 10q�6B   $��30��6T   $	��130��6`   
����������#b2b2b2.��5f   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5g   .   �� $��Refresh��68   $��SemiBold"�6G   $��12(�6]   
���   �$
 Left=�6~   $��Center=�6�   5h   +   5i   '   �� 5k   &   -   5         ��Name$ tbPrdId��5k   w   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $��10��6�   ���#edeff3{�.  $y�Hidden=�6�   ��6.   ��  �� ElementName$ listViewInventory�� �� Path$ SelectedItem.prodNo�6�   5m   #   5n      5o      5p      5q      5r      5s      � 5v   
   -	   5         �Name$ mainSubColumn��5v      $��2��6&   $��0��66   $��2��6C   $��10q�6T   .+�5w      ��  �� RadiusX$ 10��6    �� RadiusY$ 10��6%   
������� J� Effect 5x      3  -System.Windows.Media.Effects.DropShadowEffect  5y         RenderingBias$ Quality=�6'      Color$ 	#FF838383��6?      Opacity$	 0.2Q�6Q   5{      � 5}       5~      �� 5      $��1* �6$   �� 5�      $	��10* �6$   .+�5�      � $��0��6   .+�5�      � .+�5�      (� $ Uniform=�6"   $��5q�64   $
��Left=�6?   .��5�      �� $ 
Horizontal=�6)   .+�5�   "   �� ���#b2b2b2 �� CornerRadius$ 2��6?   $��1q�6P   $��Center=�6d   $��38��6   $	��650��6�   ._�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   $��5q�6e   .+�5�   *   '  !MaterialDesignThemes.Wpf.PackIcon  ���#b2b2b2�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6W   $��20��6f   $��20��6q   $��10 2 0 0q�6}   �� 5�   *   -
   5        $ 
searchSort��5�   2   
������ $��Microsoft Tai Le)�6`   $��10 0 0 0q�6~   $	��580��6�   
�������6�   5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   .+�5�   &   �� ���#BFC2C9$	��100��6C   ���#29CC97$��1q�6d   $ 15��6x   $��
20 10 0 10q�6�   ._�5�   *   �� -   5        $ exportButton��5�   1   $��Export��6G   $��12��6X   $��12(�6f   $��25��6t   
�������
������ 
������ 6�   5�   '   �� 5�   &   ���#BFC2C9$	��100��6C   ���#D6332E$��1q�6d   $ 15��6x   $��10q�6�   ._�5�   *   �� -   5        $ resetButton��5�   1   $��Reset��6F   $��12��6V   $��12(�6d   $��25��6r   
�������
������ 
������ 6�   5�   '   5�   #   5�      5�      5�      5�      � 5�      $��1��6   .+�5�      � $��10q�6   .+�5�      �� -   5         ��Name$ listViewSales��5�   #   $��5q�6:   $��Stretch=�6E   $��Stretch=�6c    �� View 5�      �� 5�   "     �� AllowsColumnReorder  .  P�5�   &   �� 5�   *   $��#��6a   ! �� Width$! 50��6l   " �� DisplayMemberBinding" 69   �� *refNo+6l   �� 5�   *   $��Prod #��6c   $	! 200��6s   " 69   �� *	salesNo+6s   �� 5�   *   $
��Item��6e   $	! 300��6s   " 69   �� *	salesItem+6s   �� 5�   *   $��Brand��6f   $	! 250��6u   " 69   �� *
salesBrand+6u   �� 5�   *   $��Category��6i   $	! 250��6{   " 69   �� *salesCategory+6{   �� 5�   *   $��
Price List��6c   $	! 100��6w   " 69   �� *	salesRP+6w   �� 5�   *   $��Quantity��6d   $	! 100��6v   " 69   �� *
salesQty+6v   �� 5�   *   $	��VAT��6d   $	! 100��6q   " 69   �� *
salesVAT+6q   �� 5�   *   $��Total��6f   $	! 100��6u   " 69   �� *
salesTotal+6u   �� 5�   *   $��Status��6g   $	! 100��6w   " 69   �� *salesStatus+6w   �� 5�   *   $��Date of Purchase��6e   $	! 200��6   " 69   �� *	salesDate+6   5�   #   5�      5�      5�      5�      5�      5�      5�      