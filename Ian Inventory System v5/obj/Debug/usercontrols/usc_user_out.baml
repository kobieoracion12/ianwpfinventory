   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      :    4NavigationDrawerPopUpMenu2.usercontrols.usc_user_out   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      -   5        .��5      � ���#F5F6FA.+�5   
   � $��10q�6     � RowDefinitions  5      �� 5      $	��30* �6    �� 5      $
��120* �6    .+�5      � $��0��6   .+�5      ��  �� RadiusX$ 10��6    �� RadiusY$ 10��6)   
�������$��10q�6C    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6+      Color$ 	#FF838383��6C      Opacity$	 0.2Q�6U   5      � 5      $��10q�6   .+�5      (�  (� Stretch$ Uniform=�6   $��10q�60   .��5      ��  �� Orientation$ Vertical=�6%   .+�5      �� $��Barcode Entry..��6$   �� 5       -   5        	 ��Name$	 entrySearch��5    &   $��Microsoft Tai Le)�6;   $��40(�6Y   $
��1100��6g   $��
20 10 20 0q�6w   
�������6�   5!      5"      5#      5$      � 5(      $��1��6   .+�5)      �� $ 10��6   $ 10��6)   
�������$��10q�6C    5*        5+      $ Quality=�6+   $ 	#FF838383��6C   $	 0.2Q�6U   5-      � 5/        50      �� 51      $	��65* �6(   �� 52      $
��383* �6(   .+�56      � $��0��6   .+�57      � $��10q�6   
 � ColumnDefinitions
 58      �� 59   "   $��* �63   �� 5:   "   $��* �63   .+�5>      � $��0��6#   .+�5?   "   (� $ Uniform=�6*   .��5@   &   �� $	��170��6-   $��20��69   .+�5A   *   �� $ 
Horizontal=�65    �� Left$ 0��6N   .+�5B   .   �� -   5         ��Name$ saveStockOutBtn��5B   5   $��5 5 5 10q�6N   $��15��6`   
����������#b2b2b2.��5C   2   �� $ 
Horizontal=�6=   $
��Left=�6V   .+�5D   6   �� $
��Save��6@   $��SemiBold"�6L   $��5(�6b   
���   � �� TextAlignment$
 Left=�6�   $��Center=�6�   5E   3   5F   /   �� 5H   .   -   5        $ changeQtyBtn��5H   5   $��0 5 5 10q�6K   $��15��6]   
����������#b2b2b2.��5I   2   �� $ 
Horizontal=�6=   $
��Left=�6V   .+�5J   6   �� $��Quantity��6@   $��SemiBold"�6P   $��5(�6f   
���   �$
 Left=�6�   $��Center=�6�   5K   3   5L   /   �� 5N   .   -   5        $ removeStockOutBtn��5N   5   $��0 5 5 10q�6P   $��15��6b   
����������#b2b2b2.��5O   2   �� $ 
Horizontal=�6=   $
��Left=�6V   .+�5P   6   �� $��Remove��6@   $��SemiBold"�6N   $��5(�6d   
���   �$
 Left=�6�   $��Center=�6�   5Q   3   5R   /   �� 5T   .   -   5        $ clearStockOutBtn��5T   5   $��0 5 5 10q�6O   $��15��6a   
����������#b2b2b2.��5U   2   �� $ 
Horizontal=�6=   $
��Left=�6V   .+�5V   6   �� $��Clear��6@   $��SemiBold"�6M   $��5(�6c   
���   �$
 Left=�6�   $��Center=�6�   5W   3   5X   /   5Y   +   5[   '   5\   #   5]      � 5`      $��1��6#   .+�5a   "   � .+�5b   &   (� $ Uniform=�6.   $	��Top=�6@   .��5c   *   �� $	��170��61   $��20��6=   .+�5d   .   �� $ 
Horizontal=�69    �� Right$ 0��6R   .+�5e   2   �� $��Stock Out #:��6<   $
 Left=�6P   $��7(�6e   $��Segoe UI Regular)�6r   $��0 7 5 10q�6�   �� 5f   2   -   5         ��Name$ orderNo��5f   <   $��00000000000��6M   $
 Left=�6`   $��7(�6u   $��Segoe UI Regular)�6�   $��	0 7 10 10q�6�   5g   /   �� 5h   .   -   5        $	 	tbPrdName��5h   ~   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   ���#edeff3{�.  $y�Hidden=�6�   ��66   �� *SelectedItem.stockoutItem+ �� ElementName$ listViewinVoice��6�   5i   +   5j   '   5k   #   5l      5m      5n      � 5p      $��1��6   .+�5q      � .+�5r      �� -	   5         ��Name$ listViewinVoice��5r   '   $��15(�6@    �� SelectionMode$ Single=�6N   $��
15 0 15 15q�6e    �� View 5s   "   �� 5t   &    �� AllowsColumnReorder .  P�5u   *   �� 5v   .   $��	Product #��6j    �� Width$	 150��6}    �� DisplayMemberBinding 6=   �� *
stockoutNo+6}   �� 5w   .   $
��Item��6l   $	 250��6z    6=   �� *stockoutItem+6z   �� 5x   .   $	��Qty��6k   $	 100��6x    6=   �� *stockoutQty+6x   5z   '   5|      5}      5~      5�      5�      5�      5�      5�      