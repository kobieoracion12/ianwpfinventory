   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      ?    9NavigationDrawerPopUpMenu2.usercontrols.usc_stock_history   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      .��5      � ���#F5F6FA.+�5   
   ��   �� RadiusX$  10��6    �� RadiusY$ 10��6!   
�������$��10q�6;    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6#      Color$ 	#FF838383��6;      Opacity$	 0.2Q�6M   5      � 5   
   $��10q�6    � RowDefinitions 5      �� 5      $	��20* �6    �� 5      $
��130* �6     � ColumnDefinitions 5      �� 5      $
��638* �6#   �� 5      $
��175* �6#   .+�5      � $��0��6   $��2��6    .+�5      � .+�5       (�  (� Stretch$ Uniform=�6   $��5q�60   $
��Left=�6;   .��5!      �� 	 �� Orientation$	 
Horizontal=�6%   .+�5"      �� ���#b2b2b2
 �� CornerRadius$
 2��6;   $��1q�6L   $��Center=�6`   $��38��6{   $	��650��6�   ._�5#   "   �� $	 
Horizontal=�6-   $��Center=�6F   $��5q�6a   .+�5$   &   '  !MaterialDesignThemes.Wpf.PackIcon  ���#b2b2b2�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6S   $��20��6b   $��20��6m   $��10 2 0 0q�6y   �� 5%   &   -   5         ��Name$ tbSearch��5%   .   
������ $��Microsoft Tai Le)�6Z   $��10 0 0 0q�6x   $	��580��6�   
�������6�   5&   #   5'      �� 5)      $	 
Horizontal=�6)   .+�5*   "   �� ���#E86845$	��100��6?   ���#E86845$��1q�6`   $
 15��6t   $��
10 10 0 10q�6�   ._�5+   &   �� -   5         ��Name$ removeButton��5+   -   $��Remove��6C   $��12��6T   $��12(�6b   $��25��6p   
�������
������ 
������ 6�   5,   #   �� 5.   "   ���#5C9EF4$	��100��6?   ���#5C9EF4$��1q�6`   $
 15��6t   $��
10 10 0 10q�6�   ._�5/   &   �� -   5        $ exportButton��5/   -   $��Export��6C   $��12��6T   $��12(�6b   $��25��6p   
�������
������ 
������ 6�   50   #   �� 53   "   ���#BFC2C9$	��100��6?   ���#D6332E$��1q�6`   $
 15��6t   $��10q�6�   ._�54   &   �� -   5        $ resetButton��54   -   $��Reset��6B   $��12��6R   $��12(�6`   $��25��6n   
�������
������ 
������ 6�   55   #   57      58      59      5:      5;      � 5>      $��1��6   .+�5?      � .+�5@      �� -   5         ��Name$ listViewRecords��5@      $��Stretch=�68   $��Stretch=�6V    �� SelectionMode$ Single=�6r   $��10q�6�    �� View 5A      �� 5B       �� AllowsColumnReorder .  P�5C   "   �� 5D   &   $��#��6a    �� Width$ 50��6l    �� DisplayMemberBinding 65   �� *	stockinId+6l   �� 5E   &   $��Ref #��6d   $	 200��6s    65   �� *stockinRefNo+6s   �� 5F   &   $��Item No.��6d   $	 200��6v    65   �� *stockinPcode+6v   �� 5G   &   $
��Item��6c   $	 300��6q    65   �� *stockinItem+6q   �� 5H   &   $	��Qty��6b   $	 100��6o    65   �� *
stockinQty+6o   �� 5I   &   $��Price��6d   $	 100��6s    65   �� *stockinPrice+6s   �� 5J   &   $
��Date��6c   $	 150��6q    65   �� *stockinDate+6q   �� 5K   &   $��Status��6e   $	 100��6u    65   �� *stockinStatus+6u   5M      5O      5Q      5R      � 5U      $��1��6   $��1��6#   .+�5V      � $��15q�6   .+�5W      (� $ Uniform=�6   $	��Top=�60   .��5X      �� $	 Vertical=�6%   .+�5Z      �� $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5[   "   �� $��Date of Arrival (From)��6,   $��Center=�6J   $
��Bold"�6g   $��10(�6y   $��0 0 0 5q�6�   (  "System.Windows.Controls.DatePicker  5\   "   -   5          Name$ sortDOAfrom��5\   -   $��12(�6B      Text$ Select��6P   $��1q�6^   $��5q�6r   $��Microsoft Tai Le)�6~   $��25��6�   $	��130��6�   $��Center=�6�   
���   ����#b2b2b26�   5]      �� 5`      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5a   "   �� $��Date of Arrival (To)��6,   $��Center=�6H   $
��Bold"�6e   $��10(�6w   $��0 10 0 5q�6�     5b   "   -   5        $ 	sortDOAto��5b   -   $��12(�6�   $��1q�6�   $��10 0 0 0q�6�   $��Microsoft Tai Le)�6�   $��25��6�   $	��130��6�   $��Center=�6  
���   ����#b2b2b2 6@   ��  �� Today �� Source# Z  �� StringFormat$ {0:yyyy MM, dd}��61  5c      �� 5f      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5g   "   �� $��Status��6,   $��Center=�6:   $
��Bold"�6W   $��10(�6i   $��0 10 0 5q�6w   �� 5h   "   -   5         ��Name$ 
sortStatus��5h   +   $��1q�6?   $��5q�6S   $��Microsoft Tai Le)�6_   $��10(�6}   $��25��6�   $	��130��6�   $��Center=�6�   ���#b2b2b2 �� 
IsEditable . .@�5i   &   �� $��Select��63    �� 
IsSelected . 6D   5j   #   5k      �� 5m      $��Stretch=�6(   $��Stretch=�6D   ���#b2b2b2$��20 20 20 10q�6s   �� 5p      -	   5        $ 
sortButton��5p   %   $��	5 10 5 10q�69   $��30��6L   $	��130��6X   
����������#b2b2b2.��5q   "   �� $	 
Horizontal=�6-   $
��Left=�6F   .+�5r   &   �� $��Filter��60   $��SemiBold"�6>   $��12(�6T   
���   � �� TextAlignment$
 Left=�6u   $��Center=�6�   5s   #   5t      �� 5w      -
   5        $ refreshItem��5w   %   $��5 0 5 10q�6:   $��30��6L   $	��130��6X   
����������#b2b2b2.��5x   "   �� $	 
Horizontal=�6-   $
��Left=�6F   .+�5y   &   �� $��Refresh��60   $��SemiBold"�6?   $��12(�6U   
���   �$
 Left=�6v   $��Center=�6�   5z   #   5{      �� 5}      -   5        $ tbPrdId��5}   p   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $��10��6�   ���#edeff3{�.  $y�Hidden=�6�   ��6&   ��  �� ElementName$ listViewRecords�� �� Path$ SelectedItem.stockinId�6�   5      5�      5�      5�      5�      5�      5�      