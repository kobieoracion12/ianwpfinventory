   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      :    4NavigationDrawerPopUpMenu2.usercontrols.usc_category   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      .��5
      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��70 �6   �� 5      $
��200* �6   �� 5      $
��350* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   � $��1��6   $��2��6   ���#FFFFFF.+�5      � .+�5      (�  (� Stretch$ Uniform=�6   $��Center=�6,   .��5      �� $	��250��6   $��20��6)   .+�5      �� $��Manage Category��6$   $��4(�6;   $��Segoe UI Bold)�6H   
���   � �� Left$ 8��6v   
 �� Top$ 7��6�   5      5      (� 5      $ Uniform=�6   $��Right=�6,   .��5       ��  �� Orientation$ 
Horizontal=�6!    �� Right$ 10��6:   $��25q�6L   .+�5!      �� -   5         ��Name$ 	addButton��5!   !   $��0 0 8 0q�6L   $��30��6]   $	��100��6i   
����������#54b971.��5"      �� $ 
Horizontal=�6)   $
��Left=�6B   .+�5#   "   �� $	��Add��6,   $��SemiBold"�67   $��12(�6M   ���#54b971 �� TextAlignment$
 Left=�6p   $��Center=�6�   5$      5%      �� 5'      -   5        $ 
editButton��5'   !   $��0 0 8 0q�6N   $��30��6_   $	��100��6k   
����������#5c9ef4.��5(      �� $ 
Horizontal=�6)   $
��Left=�6B   .+�5)   "   �� $
��Edit��6,   $��SemiBold"�68   $��12(�6N   ���#5c9ef4$
 Left=�6q   $��Center=�6�   5*      5+      �� 5-      -   5        $ removeButton��5-   !   $��0 0 8 0q�6R   $��30��6c   $	��100��6o   
����������#D6332E.��5.      �� $ 
Horizontal=�6)   $
��Left=�6B   .+�5/   "   �� $��Delete��6,   $��SemiBold"�6:   $��12(�6P   ���#D6332E$
 Left=�6s   $��Center=�6�   50      51      53      54      55      56      � 59   
   $��1��6   $��1��6   $��2��6,   .+�5:      � .+�5;      � $��1��6   .+�5<      �� 	 �� RadiusX$	 10��6    
 �� RadiusY$
 10��6-   
�������$��10q�6G    J� Effect 5=      3  -System.Windows.Media.Effects.DropShadowEffect  5>         RenderingBias$ Quality=�6/      Color$ 	#FF838383��6G      Opacity$	 0.2Q�6Y   5@      � 5B      $��20q�6    5C      �� 5D      $	��50* �6,   �� 5E      $
��420* �6,   .+�5H      � $��0��6   .+�5I      � .+�5J   "   (� $ Uniform=�6*   $
��Left=�6<   $��Stretch=�6W   .��5K   &   �� $ Vertical=�61   .+�5L   *   �� $��Search Category��60   $��Black"�6J   $��6(�6]   $��0 0 0 0q�6j   �� 5M   *   -   5         ��Name$ entrySearch��5M   2   $��Microsoft Tai Le)�6G   $��12(�6e   $	��290��6s   
�������$��10 0 0 0q�6�   6�   5N   '   5O   #   �� 5R   "   -   5        $ itemCtg��5R   *   $y�Hidden=�6�   ��6;   ��  �� ElementName$ listViewCategory�� �� Path$  SelectedItem.category_name�6�   5S      5T      � 5V      $��1��6   .+�5W      �� -   5         ��Name$ listViewCategory��5W   '   $��Stretch=�6A   $��Stretch=�6_    �� SelectionMode$ Single=�6{   $��20(�6�    �� View 5X   "   �� 5Y   &    �� AllowsColumnReorder .  P�5Z   *   �� 5[   .   $��Category��6m    �� Width$	 200��6    �� DisplayMemberBinding 6=   �� *category_name+6   5]   '   5_      5`      5a      5b      5c      5d      � 5f   
   $��2��6   $��1��6   $��2��6,   .+�5g      � .+�5h      �� $	 10��6   $
 10��6)   
�������$��10q�6C    5i        5j      $ Quality=�6+   $ 	#FF838383��6C   $	 0.2Q�6U   5l      � 5n      $��10q�6   .+�5o      �� -   5        $ listViewBrowse��5o      $��Stretch=�67   $��Stretch=�6U   $ Single=�6q    5p      �� 5q       .  P�5r   "   �� 5s   &   $��#��6^   $	 120��6i    65   �� *prodNo+6i   �� 5t   &   $
��Item��6`   $	 300��6n    65   �� *
prodItem+6n   �� 5u   &   $��Brand��6a   $	 150��6p    65   �� *	prodBrand+6p   �� 5v   &   $��	Catergory��6d   $	 150��6w    65   �� *prodCategory+6w   5x      5z      5{      5|      5}      5�      5�      