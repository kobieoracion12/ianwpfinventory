   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      A    ;NavigationDrawerPopUpMenu2.usercontrols.UserControlStockInv   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      .��5      � ���#EDEFF3  � ColumnDefinitions  5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   � $��0��6   $��0��6   $��3��6,   
�������$��70 0 0 0q�6S    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6#      Color$ 	#FF838383��6;      Opacity$	 0.2Q�6M     5      �� 5      $
��315* �6#   �� 5      $
��190* �6#   .+�5"      � $��0��6   .+�5#      � $��20q�6   .+�5$      ��  �� Orientation$ 
Horizontal=�6!   .+�5%      �� ���#b2b2b2 J� Opacity$	 0.5Q�67    �� CornerRadius$ 2��6E   $��1q�6V   $
��Left=�6j   $��Center=�6�   $��38��6�   $	��530��6�   ._�5&      �� $ 
Horizontal=�6)   $��Center=�6B   $��5q�6]   .+�5'   "   '  !MaterialDesignThemes.Wpf.PackIcon  ���#b2b2b2�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]	   Kind$	 Magnify=�6O   $��20��6^   $��20��6i   $��10 2 0 0q�6u   �� 5(   "   -   5        
 ��Name$
 tbSearch��5(   *   
������ $��Microsoft Tai Le)�6V   $��10 0 0 0q�6t   $	��460��6�   
�������6�   5)      5*      �� 5+      $��Stretch=�6$   ���#b2b2b2$��55 0 0 0q�6Q   5,      5-      5.      � 51      $��1��6   .+�52      � $��10q�6   .+�53      �� $ 
Horizontal=�6!   $��Right=�6:   .+�54      �� -   5        $
 tbPrdId��54   k   $��Microsoft Tai Le)�6|   $��15(�6�   $��30��6�   $��10��6�   ���#edeff3{�.  $y�Hidden=�6�   ��6"   ��  �� ElementName$ listViewInventory�� �� Path$ SelectedItem.prodNo�6�   �� 55      -   5         ��Name$ addItem��55   !   $��Add Item��62   $��5 0 5 0q�6E   ���#54B971���	#FF2CAE266�   �� 56      -   5        $ editItem��56   !   $
��Edit��63   $��5 0 5 0q�6B   ���#5C9EF46h   �� 57      -   5        $ 
deleteItem��57   !   $��Delete��65   $��5 0 5 0q�6F   ���#E86845���	#FFFF6C6C6�   �� 58      -   5        $ sortRestock��58   !   $��Restock��66   $��5 0 5 0q�6H   ���#54B971���	#FF2CAE266�   5:      5;      5<      5=      � 5@   
   $��1��6   $��0��6   $��3��6,   
�������$��
70 10 0 10q�6S    5A        5B      $ Quality=�6#   $ 	#FF838383��6;   $	 0.2Q�6M   .+�5E      �   5F      �� 5G      $��* �6'   �� 5H      $��* �6'   �� 5I      $��* �6'   �� 5J      $��* �6'   .+�5N      � $��0��6   .+�5O      �� $ 
Horizontal=�6!   $��Center=�6:   $
��Left=�6U   .+�5P      �� $��Date of Arrival��6$   $��Center=�6;   $
��Bold"�6V   $��10(�6h   ���#b2b2b2$��30 0 0 0q�6�   (  "System.Windows.Controls.DatePicker  5Q      -   5          Name$ sortDOA��5Q   %      Text$ Select��66   $��1q�6D   $��5q�6X   $��Microsoft Tai Le)�6d   $��10(�6�   $	��110��6�   $��10 0 0 0q�6�   $��Center=�6�   
�������6�   5R      5S      � 5U      $��0��6   .+�5V      �� $��Stretch=�6    $��Right=�6<   ���#b2b2b2$��	0 10 0 10q�6i   5W      � 5Z      $��1��6   .+�5[      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6U   .+�5\      �� $��Expiration Date��6$   $��Center=�6;   $
��Bold"�6V   $��10(�6h   ���#b2b2b2$��30 0 0 0q�6�     5]      -   5        $ sortEXPD��5]   %   $ Select��67   $��1q�6E   $��5q�6Y   $��Microsoft Tai Le)�6e   $��10(�6�   $	��110��6�   $��10 0 0 0q�6�   $��Center=�6�   
�������6�   5^      5_      � 5a      $��1��6   .+�5b      �� $��Stretch=�6    $��Right=�6<   ���#b2b2b2$��	0 10 0 10q�6i   5c      � 5f      $��2��6   .+�5g      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6U   .+�5h      �� $��Brand��6$   $��Center=�61   $
��Bold"�6L   $��10(�6^   ���#b2b2b2$��20 0 0 0q�6�   �� 5i      -	   5         ��Name$ 	sortBrand��5i   #   $��1q�66   $��5q�6J   $��Microsoft Tai Le)�6V   $��10(�6t   $	��110��6�   $��10 0 0 0q�6�   
�������$��Center=�6�   .@�5j      �� $��Select��6+    �� 
IsSelected . 6<   5k      5l      5m      � 5p      $��3��6   .+�5q      �� $ 
Horizontal=�6!   $��Center=�6:   $��Right=�6U   .+�5r      �� -
   5        $ 
sortButton��5r   !   $��Filter��65   $	��100��6F   $��	15 0 15 0q�6R   6e   �� 5s      -   5        $ refreshItem��5s   !   $��Refresh��66   $	��100��6H   $��0 0 15 0q�6T   ���	#FFE8DB45���	#FFC9E4246�   5t      5u      5v      5w      � 5z   
   $��2��6   $��0��6   $��3��6,   
�������$��80 0 0 0q�6S   .+�5{      � .+�5|      �� -   5         ��Name$ listViewInventory��5|      $��Stretch=�66   $��Stretch=�6T    �� SelectionMode$ Single=�6q    �� View 5}      �� 5~       �� AllowsColumnReorder .  P�5      �� 5�   "   $��#��6Y    �� Width$ 50��6d    �� DisplayMemberBinding 61   �� *refNo+6d   �� 5�   "   $��	Product #��6Z   $	 200��6m    61   �� *prodNo+6m   �� 5�   "   $
��Item��6\   $	 300��6j    61   �� *
prodItem+6j   �� 5�   "   $	��Qty��6[   $	 100��6h    61   �� *	prodQty+6h   �� 5�   "   $��Brand��6]   $	 250��6l    61   �� *	prodBrand+6l   �� 5�   "   $	��SRP��6[   $	 100��6h    61   �� *	prodSRP+6h   �� 5�   "   $��Retail Price��6Z   $	 120��6p    61   �� *prodRP+6p   �� 5�   "   $��Date of Arrival��6[   $	 200��6t    61   �� *	prodDOA+6t   �� 5�   "   $��Expiration Date��6\   $	 200��6u    61   �� *
prodEXPD+6u   5�      5�      5�      5�      5�      5�      