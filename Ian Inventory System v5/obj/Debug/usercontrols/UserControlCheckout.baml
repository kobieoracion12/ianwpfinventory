   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      A    ;NavigationDrawerPopUpMenu2.usercontrols.UserControlCheckout   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Alocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols  5      0sys&clr-namespace:System;assembly=mscorlib  5      -   5        .��5      � ���#EDEFF3  � ColumnDefinitions  5   
   �� 5      $
��368* �6   �� 5      $
��357* �6   �� 5      $
��295* �6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��43* �6   �� 5      $
��141* �6   �� 5      $	��30* �6   .+�5   
   � $��0��6   $��0��6   $��4��6,   
�������$��70 0 0 0q�6S    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6#      Color$ 	#FF838383��6;      Opacity$	 0.2Q�6M   .+�5"      �� $��1��6   $��0��6&    �� Orientation$ 
Horizontal=�66   $��Center=�6O   .+�5#      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Download=�6*   $��25��6:   $��25��6E   $��50 0 0 0q�6Q   �� 5$      $��	Stock Out��6    �� TextAlignment$
 Left=�6-   $��20(�6B   $��Segoe UI Semibold)�6P   $��5 0 0 0q�6o   �� 5&      $��Stock Out #��6   $��5 0 0 0q�6/   �� 5'      -   5        	 ��Name$	 orderNo��5'      $��00000��6-   $��5 0 0 0q�6:   �� 5(      -   5        
 ��Name$
 	tbPrdName��5(   g   $��Microsoft Tai Le)�6z   $��15(�6�   $��30��6�   $	��300��6�   ���#edeff3{�.  $y�Hidden=�6�   ��6   ��  �� ElementName$ listViewinVoice�� �� Path$ SelectedItem.stockoutItem�6�   5)      5*      � 5-   
   $��1��6   $��0��6   $��4��6,   .+�5.      � .+�5/      �� $��
80 10 0 10q�6    �� RadiusX$ 8��60    �� RadiusY$ 8��6<   
������� 50        51      $ Quality=�6+   $ 	#FF838383��6C   $	 0.2Q�6U   53      � 55      $��
80 10 0 10q�6   .+�56      �� $��Enter Entry:��6   $��23 0 0 0q�63   (� 57      $
��Left=�6   $��Center=�69   .��58      �� $ 
Horizontal=�6%   .+�59      �� -   5        $
 entrySearch��59   &   $��Microsoft Tai Le)�6;   $��20(�6Y   $��50��6g   $	��800��6s   $��20 25 20 20q�6�   
�������6�   �� 5:      
������ 
������ $	��100��6X   $��60��6d   $��60 0 0 0q�6p   .��5;   "     $ Printer=�6:   
���   �$��50��6\   $��50��6g   5<      5=      5>      5?      5@      5A      � 5F   
   $��2��6   $��0��6   $��4��6,   .+�5G      � .+�5H      �� $��	80 0 0 10q�6   $ 8��6/   $ 8��6;   
������� 5I        5J      $ Quality=�6+   $ 	#FF838383��6C   $	 0.2Q�6U   5L      � 5N      $��
80 10 0 10q�6   .+�5O      �� -   5         ��Name$ listViewinVoice��5O      $��15(�68    �� SelectionMode$ Single=�6F   $��10q�6]    �� View 5P      �� 5Q       �� AllowsColumnReorder .  P�5R   "   �� 5S   &   $��#��6b    �� Width$	 160��6m    �� DisplayMemberBinding 65   �� *
stockoutId+6m   �� 5T   &   $
��Item��6d   $	 350��6r    65   �� *stockoutItem+6r   �� 5U   &   $��Price��6e   $	 100��6t    65   �� *stockoutPrice+6t   �� 5V   &   $	��Qty��6c   $	 100��6p    65   �� *stockoutQty+6p   5X      5Z      5[      5\      5]      � 5_   
   $��3��6   $��4��6   .+�5`      � $��80 0 0 0q�6   .+�5a      (�  (� Stretch$ Uniform=�6   $��Right=�6,   .��5b      �� $ 
Horizontal=�6!   $��15q�6:   .+�5c      �� -   5         ��Name$ removeStockOutBtn��5c   R   $��Remove��6!   ���#D6332E���#D6332E$��0 0 8 0q�6�   �� 5d      -   5        $ clearStockOutBtn��5d   P   $��Clear��6!   ���#EC6464���#EC6464$��0 0 8 0q�6�   �� 5e      -   5        $ saveStockOutBtn��5e   N   $
��Save��6!   ���#54b971���#54b971$��0 0 8 0q�6�   5f      5g      (� 5h      $ Uniform=�6   $
��Left=�6,   .��5i      �� $ 
Horizontal=�6!   $��15q�6:   .+�5j      �� -	   5        $ viewProdBtn��5j   9   $��View Products��6!   ���#5c9ef4$��0 0 8 0q�6}   �� 5k      -
   5        $ changeQtyBtn��5k   9   $��Quantity��6O   ���#5c9ef4$��0 0 8 0q�6w   5l      5m      5n      5o      5s      5t      