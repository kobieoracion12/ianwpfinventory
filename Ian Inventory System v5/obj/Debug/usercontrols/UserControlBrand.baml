   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      >    8NavigationDrawerPopUpMenu2.usercontrols.UserControlBrand   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Alocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols  5      .��5
      � 
�������  � ColumnDefinitions  5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   � -   5         �Name$ isHeader��5      $��0��6!   $��0��6.   ���#edeff3.+�5      � $��1��6     5      �� 5      $
��436* �6'   �� 5      $
��auto �6'    5      �� 5      $��* �6$   �� 5      $��* �6$   .+�5#      �� $��0��6   $��0��6-    �� Orientation$ 
Horizontal=�6:   .+�5$      �� -   5        $��0q�5$   8   $��Center=�6L   
������ $��80 5 0 5q�6�   .��5%      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�62   $��25��6A   $��25��6L   ���#7B7873$��Center=�6m   $��Center=�6�   $��0 0 0 0q�6�   5&      �� 5'      -   5         ��Name$ tbSearch��5'      $��Microsoft Tai Le)�60   $��15(�6N   $��30��6\   $	��500��6h   $��5 5 0 5q�6t   ���#edeff36�   5(      �� 5+      $��1��6   .+�5,      �� -   5        $ tbPrdId��5,   d   $��Microsoft Tai Le)�6u   $��15(�6�   $��30��6�   $	��300��6�   $��
10 10 50 5q�6�   ���#edeff3{�.  $y�Hidden=�6�   ��6   ��  �� ElementName$ listViewInventory�� �� Path$ SelectedItem.bId�6�   5-      �� 50      $��2��6   $��1��6*   $ 
Horizontal=�6:   .+�51      �� -   5         ��Name$ 
refreshBtn��51   r   $��Refresh��6   $��Center=�6/   ���#54b971$��0 0 8 0q�6a   6�   �� 52      -   5        $ clearBtn��52   q   $��Clear��6   $��Center=�6-   ���#54b971$��0 0 8 0q�6_   6�   �� 53      -   5        $ 	removeBtn��53   q   $��Remove��6   $��Center=�6.   ���#D6332E$��0 0 8 0q�6`   6�   �� 54      -   5        $ editBtn��54   p   $
��Edit��6   $��Center=�6,   ���#5c9ef4$��0 0 8 0q�6^   6�   �� 55      -	   5        $ addBtn��55   n   $	��Add��6   $��Center=�6+   ���#5c9ef4$��0 0 8 0q�6]   6~   56      57      � 5<      $��2��6     5=      �� 5>      $
��436* �6'   �� 5?      $��1500* �6'   �� 5@      $
��auto �6'    5B      �� 5C      $��* �6$   �� 5D      $��* �6$   .+�5F      �� $��1��6   $��0��6*   $ 
Horizontal=�6:   .+�5G      �� 	 �� TextAlignment$
	 Left=�6    $��20(�65   $��Segoe UI Semibold)�6C   $��90 0 0 0q�6b   Brand6{   5H      5I      5J      � 5M   
   $��1��6   $��0��6   ���#ffffff.+�5N      �� -
   5        
 ��Name$
 listViewInventory��5N      $��Stretch=�62   $��Stretch=�6P   $��70,0,0,0q�6l    �� SelectionMode$ Single=�6~    �� View 5O      �� 5P       �� AllowsColumnReorder .  P�5Q      �� 5R      $��#��6S    �� Width$ 50��6^    �� DisplayMemberBinding 6-   �� *bId+6^   �� 5S      $��
Brand Name��6Z   $	 200��6n    6-   �� *
brand_name+6n   5U      5W      5X      5Z      5[      