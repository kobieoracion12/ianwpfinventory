   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      B    <NavigationDrawerPopUpMenu2.usercontrols.usc_parent_overviews   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      -   5        .��5      � ���#F5F6FA.+�5   
   ��   �� RadiusX$  10��6    �� RadiusY$ 10��6!   
�������$��10q�6;    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6#      Color$ 	#FF838383��6;      Opacity$	 0.2Q�6M   5      � 5   
   $��10q�6    � RowDefinitions 5      �� 5      $	��20* �6    �� 5      $
��130* �6     � ColumnDefinitions 5      �� 5      $
��638* �6#   �� 5      $
��175* �6#   .+�5      � $��0��6   $��2��6    .+�5       � .+�5!      (�  (� Stretch$ Uniform=�6   $��5q�60   $
��Left=�6;   .��5"      �� 	 �� Orientation$	 
Horizontal=�6%   .+�5#      �� ���#b2b2b2
 �� CornerRadius$
 2��6;   $��1q�6L   $��Center=�6`   $��38��6{   $	��650��6�   ._�5$   "   �� $	 
Horizontal=�6-   $��Center=�6F   $��5q�6a   .+�5%   &   '  !MaterialDesignThemes.Wpf.PackIcon  ���#b2b2b2�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6S   $��20��6b   $��20��6m   $��10 2 0 0q�6y   �� 5&   &   -   5         ��Name$ tbSearch��5&   .   
������ $��Microsoft Tai Le)�6Z   $��10 0 0 0q�6x   $	��580��6�   
�������6�   5'   #   5(      �� 5*      $	 
Horizontal=�6)   .+�5+   "   �� ���#BFC2C9$	��100��6?   ���#29CC97$��1q�6`   $
 15��6t   $��
20 10 0 10q�6�   ._�5,   &   �� -   5         ��Name$ 
editButton��5,   -   $
��Edit��6A   $��12��6P   $��12(�6^   $��25��6l   
�������
������ 
������ 6�   5-   #   �� 5/   "   ���#E86845$	��100��6?   ���#E86845$��1q�6`   $
 15��6t   $��
10 10 0 10q�6�   ._�50   &   �� -   5        $ removeButton��50   -   $��Remove��6C   $��12��6T   $��12(�6b   $��25��6p   
�������
������ 
������ 6�   51   #   �� 53   "   ���#5C9EF4$	��100��6?   ���#5C9EF4$��1q�6`   $
 15��6t   $��
10 10 0 10q�6�   ._�54   &   �� -   5        $ printButton��54   -   $��Export��6B   $��12��6S   $��12(�6a   $��25��6o   
�������
������ 
������ 6�   55   #   �� 58   "   ���#BFC2C9$	��100��6?   ���#D6332E$��1q�6`   $
 15��6t   $��10q�6�   ._�59   &   �� -   5        $ resetButton��59   -   $��Reset��6B   $��12��6R   $��12(�6`   $��25��6n   
�������
������ 
������ 6�   5:   #   5<      5=      5>      5?      5@      � 5C      $��1��6   .+�5D      � .+�5E      �� -   5         ��Name$ listViewInventory��5E      $��Stretch=�6:   $��Stretch=�6X    �� SelectionMode$ Single=�6t   $��10q�6�    �� View 5F      �� 5G       �� AllowsColumnReorder .  P�5H   "   �� 5I   &   $��	Product #��6^    �� Width$	 200��6q    �� DisplayMemberBinding 65   �� *prodNo+6q   �� 5J   &   $
��Item��6`   $	 300��6n    65   �� *
prodItem+6n   �� 5K   &   $	��Qty��6_   $	 100��6l    65   �� *	prodQty+6l   �� 5L   &   $��Brand��6a   $	 250��6p    65   �� *	prodBrand+6p   �� 5M   &   $��Purc. Price��6^   $	 100��6s    65   �� *prodRP+6s   �� 5N   &   $��	Pricelist��6_   $	 120��6r    65   �� *	prodSRP+6r   �� 5O   &   $	��VAT��6_   $	 100��6l    65   �� *	prodVAT+6l   �� 5P   &   $��Category��6d   $	 200��6v    65   �� *prodCategory+6v   �� 5Q   &   $��Date of Arrival��6_   $	 200��6x    65   �� *	prodDOA+6x   5S      5U      5W      5X      � 5[      $��1��6   $��1��6#   .+�5\      � $��15q�6   .+�5]      (� $ Uniform=�6   $	��Top=�60   .��5^      �� $	 Vertical=�6%   .+�5`      �� $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5a   "   �� $��Date of Arrival (From)��6,   $��Center=�6J   $
��Bold"�6g   $��10(�6y   $��0 0 0 5q�6�   (  "System.Windows.Controls.DatePicker  5b   "   -   5          Name$ sortDOAfrom��5b   -   $��12(�6B      Text$ Select��6P   $��1q�6^   $��5q�6r   $��Microsoft Tai Le)�6~   $��25��6�   $	��130��6�   $��Center=�6�   
���   ����#b2b2b26�   5c      �� 5f      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5g   "   �� $��Date of Arrival (To)��6,   $��Center=�6H   $
��Bold"�6e   $��10(�6w   $��0 10 0 5q�6�     5h   "   -	   5        $ 	sortDOAto��5h   -   $��12(�6�   $��1q�6�   $��10 0 0 0q�6�   $��Microsoft Tai Le)�6�   $��25��6�   $	��130��6�   $��Center=�6  
���   ����#b2b2b2 6@   ��  �� Today �� Source# Z  �� StringFormat$ {0:yyyy MM, dd}��61  5i      �� 5l      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5m   "   �� $��Brand��6,   $��Center=�69   $
��Bold"�6V   $��10(�6h   $��0 10 0 5q�6v   �� 5n   "   -
   5         ��Name$ 	sortBrand��5n   +   $��1q�6>   $��5q�6R   $��Microsoft Tai Le)�6^   $��10(�6|   $��25��6�   $	��130��6�   $��Center=�6�   ���#b2b2b2 �� 
IsEditable . .@�5o   &   �� $��Select��63    �� 
IsSelected . 6D   5p   #   5q      �� 5t      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5u   "   �� $��Category��6,   $��Center=�6<   $
��Bold"�6Y   $��10(�6k   $��0 10 0 5q�6y   �� 5v   "   -   5        $ sortCategory��5v   +   $��1q�6A   $��5q�6U   $��Microsoft Tai Le)�6a   $��10(�6   $��25��6�   $	��130��6�   $��Center=�6�   ���#b2b2b2 . .@�5w   &   �� $��Select��63    . 6D   5x   #   5y      �� 5{      $��Stretch=�6(   $��Stretch=�6D   ���#b2b2b2$��20 20 20 10q�6s   �� 5~      -   5        $ 
sortButton��5~   %   $��	5 10 5 10q�69   $��30��6L   $	��130��6X   
����������#b2b2b2.��5   "   �� $	 
Horizontal=�6-   $
��Left=�6F   .+�5�   &   �� $��Filter��60   $��SemiBold"�6>   $��12(�6T   
���   � �� TextAlignment$
 Left=�6u   $��Center=�6�   5�   #   5�      �� 5�      -   5        $ refreshItem��5�   %   $��5 0 5 10q�6:   $��30��6L   $	��130��6X   
����������#b2b2b2.��5�   "   �� $	 
Horizontal=�6-   $
��Left=�6F   .+�5�   &   �� $��Refresh��60   $��SemiBold"�6?   $��12(�6U   
���   �$
 Left=�6v   $��Center=�6�   5�   #   5�      �� 5�      -   5        $ tbPrdId��5�   o   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $��10��6�   ���#edeff3{�.  $y�Hidden=�6�   ��6&   ��  �� ElementName$ listViewInventory�� �� Path$ SelectedItem.prodNo�6�   5�      5�      5�      5�      5�      5�      5�      