   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      >    8NavigationDrawerPopUpMenu2.usercontrols.usc_pos_settings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      .��5
      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��70 �6   �� 5      $
��200* �6   �� 5      $
��350* �6    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   � $��1��6   $��0��6   $��3��6,   .+�5      ��  �� RadiusX$ 10��6    �� RadiusY$ 10��6%   
�������$��10q�6?    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6'      Color$ 	#FF838383��6?      Opacity$	 0.2Q�6Q   5      � 5      $��10q�6    5      �� 5       $��3* �6$   �� 5!      $��3* �6$   �� 5"      $��1* �6$   .+�5&      � $��0��6   $��2��6$   .+�5'      � .+�5(      �� -   5         ��Name$ listViewDiscount��5(   #   $��Stretch=�6=   $��Stretch=�6[   	 �� SelectionMode$	 Single=�6w   $��20(�6�   
 �� View
 5)      �� 5*   "    �� AllowsColumnReorder .  P�5+   &   �� 5,   *   $��Discount Name��6i    �� Width$	 200��6�    �� DisplayMemberBinding 69   �� *discount_name+6�   �� 5-   *   $��Percent��6k   $	 200��6|    69   �� *discount_percent+6|   5/   #   51      52      53      � 56      $��2��6   .+�57      � .+�58      (�  (� Stretch$ Uniform=�6"   $��Center=�64   .��59      ��  �� Orientation$ 
Horizontal=�6)    �� Right$ 10��6B   $��10q�6T   .+�5;   "   �� -   5         ��Name$ 
editButton��5;   )   $��0 0 8 0q�6=   $��30��6N   $	��100��6Z   
����������#5c9ef4.��5<   &   �� $ 
Horizontal=�61   $
��Left=�6J   .+�5=   *   �� $
��Edit��64   $��SemiBold"�6@   $��12(�6V   ���#5c9ef4 �� TextAlignment$
 Left=�6y   $��Center=�6�   5>   '   5?   #   �� 5A   "   -   5        $ removeButton��5A   )   $��30��6?   $	��100��6K   
����������#D6332E.��5B   &   �� $ 
Horizontal=�61   $
��Left=�6J   .+�5C   *   �� $��Delete��64   $��SemiBold"�6B   $��12(�6X   ���#D6332E$
 Left=�6{   $��Center=�6�   5D   '   5E   #   5G      5H      5J      5K      5O      5P      � 5R   
   $��2��6   $��0��6   $��3��6,   .+�5S      � .+�5T      �� $ 10��6   $ 10��6)   
�������$��10q�6C    5U        5V      $ Quality=�6+   $ 	#FF838383��6C   $	 0.2Q�6U   5X      �� 5Z      .+�5[      �� -   5         ��Name$ tbDiscountName��5[   m   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $	��300��6�   $��
10 10 50 5q�6�   ���#edeff3{�.  $y�Hidden=�6  ��6   ��  �� ElementName$ listViewDiscount�� �� Path$  SelectedItem.discount_name�6  5\      � 5^      -   5         �Name$ mainGrid��5^      $��20q�6)   .+�5_      �� $��Manage Discount��6    $
��Left=�67   $
��Bold"�6R   $��20(�6d   $��20q�6r   � 5`      .+�5a      (� $ Uniform=�6"   .��5b      �� $ Vertical=�6)   $��10q�6@   .+�5d   "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6_   .+�5e   &   �� $��Discount Name��60   $
��Left=�6E   $
��Bold"�6`   $��5(�6r   $��5 0 0 0q�6   �� 5f   &   -   5        $ discountName��5f   .   $��1q�6D   $��2 0 0 0q�6X   $��Microsoft Tai Le)�6j   $��8(�6�   
�������$��20��6�   $	��190��6�   $��Center=�6�   5g   #   �� 5j   "   $ Vertical=�6-   $��Center=�6D   $��Center=�6_   .+�5k   &   �� $��Discount Percent(%)��60   $
��Left=�6K   $
��Bold"�6f   $��5(�6x   $��5 5 0 0q�6�   �� 5l   &   -   5        $ discountValue��5l   .   $��1q�6E   $��2 0 0 0q�6Y   $��Microsoft Tai Le)�6k   $��8(�6�   
�������$��20��6�   $	��190��6�   $��Center=�6�   6�   5m   #   �� 5p   "   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6a   .+�5q   &   �� -   5        $ addItem��5q   -   $��0 10 5 0q�6>   $��15��6P   ���#29CC97���#29CC97.��5r   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5s   .   �� $��Submit��68   $��SemiBold"�6F   $��5(�6\   ���#FFFFFF$ Center=�6~   $��Center=�6�   5t   +   5u   '   �� 5w   &   -	   5        $ clearBtn��5w   -   $��0 10 0 0q�6?   $��15��6Q   ���#E86845���	#FFFF6C6C.��5x   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5y   .   �� $��Clear��68   $��SemiBold"�6E   $��5(�6[   ���#FFFFFF$ Center=�6}   $��Center=�6�   5z   +   5{   '   5|   #   5}      5~      5      5�      5�      5�      5�      5�      