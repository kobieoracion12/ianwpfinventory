   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      A    ;NavigationDrawerPopUpMenu2.usercontrols.UserControlSalesInv   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Alocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols  5      0sys&clr-namespace:System;assembly=mscorlib  5      .��5      � ���#EDEFF3  � ColumnDefinitions  5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   � $��0��6   $��0��6   $��3��6,   
�������$��70 0 0 0q�6S    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6#      Color$ 	#FF838383��6;      Opacity$	 0.2Q�6M   .+�5      � .+�5      � $��20q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5       �� ���#b2b2b2 J� Opacity$	 0.5Q�67    �� CornerRadius$ 2��6E   $��1q�6V   $
��Left=�6j   $��Center=�6�   $��38��6�   $	��560��6�   ._�5!      �� $ 
Horizontal=�6)   $��Center=�6B   $��5q�6]   .+�5"   "   '  !MaterialDesignThemes.Wpf.PackIcon  ���#b2b2b2�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]	   Kind$	 Magnify=�6O   $��20��6^   $��20��6i   $��10 2 0 0q�6u   �� 5#   "   -   5        
 ��Name$
 
searchSort��5#   *   
������ $��Microsoft Tai Le)�6X   $��10 0 0 0q�6v   $	��500��6�   
�������6�   5$      5%      �� 5&      $��Stretch=�6$   ���#b2b2b2$��50 0 0 0q�6Q   �� 5(      $ 
Horizontal=�6%   .+�5*      �� -   5         ��Name$ 
exportData��5*   %   $��
Clear Data��69   $	��110��6N   ���#ffb200$��	20 0 15 0q�6o   6�   �� 5,      -   5        $ exportSortedData��5,   %   $��Export File��6?   $	��110��6U   ���#ffb200$��0 0 15 0q�6v   6�   5.      50      51      52      53      � 56   
   $��1��6   $��0��6   $��3��6,   
�������$��
70 10 0 10q�6S    57        58      $ Quality=�6#   $ 	#FF838383��6;   $	 0.2Q�6M   .+�5;      �   5<      �� 5=      $��* �6'   �� 5>      $��* �6'   �� 5?      $��* �6'   �� 5@      $��* �6'   .+�5D      � $��0��6   .+�5E      �� $ 
Horizontal=�6!   $��Center=�6:   $
��Left=�6U   .+�5F      �� $
��From��6$   $��Center=�60   $
��Bold"�6K   $��10(�6]   ���#b2b2b2$��30 0 0 0q�6�   (  "System.Windows.Controls.DatePicker  5G      -   5          Name$ sortCalendarFrom��5G   %   $��1q�6?   $��5q�6S      Text$/ )StringFormat='{}{0:dddd, MMMM dd, yyyy}'}��6_   $��Microsoft Tai Le)�6�   $��10(�6�   $	��110��6�   $��10 0 0 0q�6�   $��Center=�6�   
�������6�   5H      5I      � 5K      $��0��6   .+�5L      �� $��Stretch=�6    $��Right=�6<   ���#b2b2b2$��	0 10 0 10q�6i   5M      � 5P      $��1��6   .+�5Q      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6U   .+�5R      �� $��To��6#   $��Center=�6-   $
��Bold"�6H   $��10(�6Z   ���#b2b2b2$��30 0 0 0q�6}     5\      -   5        $ sortCalendarTo��5\   %   $��1q�6=   $��5q�6Q   $��Microsoft Tai Le)�6]   $��10(�6{   $	��110��6�   $��10 0 0 0q�6�   $��Center=�6�   
�������6�   5]      5^      � 5`      $��1��6   .+�5a      �� $��Stretch=�6    $��Right=�6<   ���#b2b2b2$��	0 10 0 10q�6i   5b      � 5e      $��2��6   .+�5f      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6U   .+�5g      �� $��Brand��6$   $��Center=�61   $
��Bold"�6L   $��10(�6^   ���#b2b2b2$��20 0 0 0q�6�   �� 5h      -   5         ��Name$ 	sortBrand��5h   #   $��1q�66   $��5q�6J   $��Microsoft Tai Le)�6V   $��10(�6t   $	��110��6�   $��10 0 0 0q�6�   
�������$��Center=�6�   .@�5i      �� $��Select��6+    �� 
IsSelected . 6<   5j      5k      5l      � 5o      $��3��6   .+�5p      �� $ 
Horizontal=�6!   $��Center=�6:   $��Right=�6U   .+�5q      �� -   5        $ 
sortButton��5q   !   $
��Sort��65   $	��110��6D   $��	15 0 15 0q�6P    J� RenderTransformOrigin$ 0.5,0.5&�6|   �� 5r      -   5        $ 	sortClear��5r   !   $��Refresh��64   $	��110��6F   ���#e86845$��0 0 15 0q�6g   6y   5s      5t      5v      5w      � 5z   
   $��2��6   $��0��6   $��3��6,   
�������$��80 0 0 0q�6S   .+�5{      � .+�5|      �� -	   5         ��Name$ listViewSales��5|      $
��auto��62   $��Stretch=�6?   $��Stretch=�6]    �� View 5}      �� 5~       �� AllowsColumnReorder .  P�5      �� 5�   "   $��#��6Y    �� Width$ 50��6d    �� DisplayMemberBinding 61   �� *refNo+6d   �� 5�   "   $��Prod #��6[   $	 200��6k    61   �� *	salesNo+6k   �� 5�   "   $
��Item��6]   $	 300��6k    61   �� *	salesItem+6k   �� 5�   "   $��Brand��6^   $	 250��6m    61   �� *
salesBrand+6m   �� 5�   "   $��Date of Purchase��6]   $	 200��6w    61   �� *	salesDate+6w   �� 5�   "   $��RP��6[   $	 100��6g    61   �� *	salesRP+6g   �� 5�   "   $��Quantity��6\   $	 100��6n    61   �� *
salesQty+6n   �� 5�   "   $��Total��6^   $	 100��6m    61   �� *
salesTotal+6m   5�      5�      5�      5�      5�      5�      