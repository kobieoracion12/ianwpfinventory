   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      =    7NavigationDrawerPopUpMenu2.usercontrols.usc_stockreturn   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      .��5      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��130* �6   .+�5   
   � $��1��6   $��0��6   $��2��6,   .+�5      � $��10q�6   .+�5      ��  �� RadiusX$ 10��6    �� RadiusY$ 10��6)   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6+      Color$ 	#FF838383��6C      Opacity$	 0.2Q�6U   5      � 5      $��10q�6    5       �� 5!      $	��50* �6(   �� 5"      $
��420* �6(   .+�5%      � $��0��6   .+�5&      � .+�5'      (�  (� Stretch$ Uniform=�6&   $
��Left=�69   .��5(   "   �� 	 �� Orientation$	 
Horizontal=�6-   $��Center=�6F   .+�5*   &   �� $	 Vertical=�61   .+�5+   *   �� $��Enter Trans#��64   $
��Left=�6H   $
��Bold"�6c   $��10(�6u   $��5 0 5 5q�6�   �� 5,   *   -   5        
 ��Name$
 itemo��5,   2   $��1q�6A   $��2 0 0 0q�6U   $��Microsoft Tai Le)�6g   $��8(�6�   
�������$��25��6�   $	��150��6�   $��Center=�6�   6�   5-   '   �� 5/   &   $	 Vertical=�61   $��10 0 0 0q�6H   .+�50   *   �� $��Select Date��64   $
��Left=�6G   $
��Bold"�6b   $��10(�6t   $��5 0 5 5q�6�   (  "System.Windows.Controls.DatePicker  51   *   -   5          Name$ sortCashier��51   5   $��1q�6�   $��Microsoft Tai Le)�6�   $��10(�6�   $��25��6�   $	��130��6�   $��Center=�6     Text 6J   ��  �� Today �� Source# Z  �� StringFormat$ {0:dddd, MMMM dd, yyyy}��6  53   '   �� 55   &   $	 
Horizontal=�61   .+�56   *   �� $��Filter��61   ���#2C9CDB���#2C9CDB$��10(�6m   $��25��6{   $��10 0 0 0q�6�   57   '   59   #   5:      5;      5<      � 5>      $��1��6   .+�5?      �� -   5         ��Name$ 	lv_browse��5?   #   $��Stretch=�66   $��Stretch=�6T    �� SelectionMode$ Single=�6p   $��10q�6�    �� View 5@      �� 5A   "    �� AllowsColumnReorder .  P�5B   &   �� 5C   *   $��#��6f    �� Width$ 50��6q    �� DisplayMemberBinding 69   �� *
stockoutId+6q   �� 5D   *   $��Trans #��6k   $	 200��6|    69   �� *stockoutTransNo+6|   �� 5E   *   $
��Item��6h   $	 300��6v    69   �� *stockoutItem+6v   �� 5F   *   $	��Qty��6g   $	 100��6t    69   �� *stockoutQty+6t   �� 5G   *   $��Date of Purchase��6h   $	 200��6�    69   �� *stockoutDate+6�   5I   #   5K      5L      5N      5O      5P      � 5S   
   $��2��6   $��0��6   $��2��6,   .+�5T      �� $��Stock Return��6   $
��Left=�6,   $
��Bold"�6G   $��20(�6Y   $��30q�6g   � 5U      $��2��6   .+�5V      (� $ Uniform=�6   $��2��6,   .��5W      �� $	��210��6   $	��290��6)   .+�5X      �� $	 Vertical=�6%   $��10q�6<   
 �� Top$ 30��6H   .+�5Z      �� $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5[   "   �� $��Transaction Number��6,   $
��Left=�6F   $
��Bold"�6a   $��5(�6s   $��5 0 0 0q�6�   �� 5\   "   -   5        $
 itemTransNo��5\   *   $��1q�6@   $��2 0 0 0q�6T   $��Microsoft Tai Le)�6f   $��8(�6�   
�������$��20��6�   $	��190��6�   $��Center=�6�   {�.  6�   5]      �� 5`      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5a   "   �� $��Item Number��6,   $
��Left=�6?   $
��Bold"�6Z   $��5(�6l   $��5 10 0 0q�6y   �� 5b   "   -   5        $
 itemNo��5b   *   $��1q�6;   $��2 0 0 0q�6O   $��Microsoft Tai Le)�6a   $��8(�6   
�������$��20��6�   $	��190��6�   $��Center=�6�   {�.  6�   5c      �� 5f      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5g   "   �� $��Item Description��6,   $
��Left=�6D   $
��Bold"�6_   $��5(�6q   $��5 10 0 0q�6~   �� 5h   "   -   5        $
 itemName��5h   *   $��1q�6<   $��Microsoft Tai Le)�6P   $��8(�6n   
�������$��2 0 0 0q�6�   $��20��6�   $	��190��6�   $��Center=�6�   {�.  6�   5i      �� 5l      $	 
Horizontal=�6)   $��Center=�6B   $��Center=�6]   .+�5m   "   �� $	 Vertical=�6-   .+�5n   &   �� $��Quantity��60   $
��Left=�6@   $
��Bold"�6[   $��5(�6m   $��5 10 0 0q�6z   �� 5o   &   -   5        $
 itemQty��5o   .   $��1q�6?   $��Microsoft Tai Le)�6S   $��8(�6q   
�������$��2 0 0 0q�6�   $��20��6�   $��91��6�   $��Center=�6�   {�.  6�   5p   #   �� 5r   "   $	 Vertical=�6-   $��9 0 0 0q�6D   .+�5s   &   �� $��	To Return��60   $
��Left=�6A   $
��Bold"�6\   $��5(�6n   $��5 10 0 0q�6{   �� 5t   &   -   5        $
 
itemReduce��5t   .   $��1q�6B   $��Microsoft Tai Le)�6V   $��8(�6t   
�������$��2 0 0 0q�6�   $��20��6�   $��91��6�   $��Center=�6�   {�.  6�   5u   #   5v      �� 5y      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5z   "   �� $��Date of Stock Out��6,   $
��Left=�6E   $
��Bold"�6`   $��5(�6r   $��5 10 0 0q�6     5{   "   -	   5        $ itemDOP��5{   -   $��8(�6>   $��20��6K   $��1q�6W   $��Microsoft Tai Le)�6k   
�������$��2 0 0 0q�6�   $	��190��6�   $��Center=�6�   {�.  6�   5|      �� 5      $	 
Horizontal=�6)   $��Center=�6B   $��Center=�6]   .+�5�   "   �� -
   5         ��Name$ addItem��5�   )   $��0 10 5 0q�6:   $��15��6L   ���#29CC97���#29CC97.��5�   &   �� $	 
Horizontal=�61   $
��Left=�6J   .+�5�   *   �� $��Return��64   $��SemiBold"�6B   $��5(�6X   ���#FFFFFF �� TextAlignment$ Center=�6z   $��Center=�6�   5�   '   5�   #   �� 5�   "   -   5        $ addIem��5�   )   $��0 10 0 0q�69   $��15��6K   ���#E86845���	#FFFF6C6C.��5�   &   �� $	 
Horizontal=�61   $
��Left=�6J   .+�5�   *   �� $��Clear��64   $��SemiBold"�6A   $��5(�6W   ���#FFFFFF$ Center=�6y   $��Center=�6�   5�   '   5�   #   5�      �� 5�      $	 
Horizontal=�6)   .+�5�   "   �� -   5         ��Name$ curQty��5�   ,   $��50��6<   $ Center=�6G   $y�Hidden=�6^   �� 5�   "   -   5        $ remQty��5�   ,   $��50��6<   $ Center=�6G   $y�Hidden=�6^   �� 5�   "   -   5        $
 stockid��5�   *   $��50��6�    �� TextAlignment$ Center=�6�   $y�Hidden=�6�   ��6;   ��  �� ElementName$ 	lv_browse�� �� Path$ SelectedItem.stockoutId�6�   5�      5�      5�      5�      5�      5�      5�      5�      