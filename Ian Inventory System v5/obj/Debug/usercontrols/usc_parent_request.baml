   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      @    :NavigationDrawerPopUpMenu2.usercontrols.usc_parent_request   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      6sys&clr-namespace:System;assembly=mscorlib     5      .��5      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��130* �6   .+�5   
   � $��0��6   $��0��6   $��2��6,   .+�5      � $��10q�6   .+�5      ��  �� RadiusX$ 10��6    �� RadiusY$ 10��6)   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6+      Color$ 	#FF838383��6C      Opacity$	 0.2Q�6U   5      � 5      $��10q�6    5       �� 5!      $	��50* �6(   �� 5"      $
��420* �6(   .+�5&      � $��0��6   .+�5'      � .+�5(      (�  (� Stretch$ Uniform=�6&   $
��Left=�69   .��5)   "   �� 	 �� Orientation$	 
Horizontal=�6-   $��Center=�6F   $��12q�6a   .+�5*   &   �� $��Cashier��60   $��Center=�6?   $
��Bold"�6\   $��10(�6n   $��5 5 10 5q�6|   �� 5+   &   -   5        
 ��Name$
 sortCashier��5+   /   $��1q�6D   $��5q�6X   $��Microsoft Tai Le)�6d   $��10(�6�   $��25��6�   $	��130��6�   $��Center=�6�   .@�5,   *   �� $��Select��67    �� 
IsSelected . 6H   5-   '   �� 5/   &   -   5         ��Name$ selectCashier��5/   -   $��20 0 0 0q�6D   $��25��6V   $	��100��6b   ���#2C9CDB���#2C9CDB.��50   *   �� $	 
Horizontal=�65   $
��Left=�6N   .+�51   .   �� $��Select��68   $��SemiBold"�6F   $��8(�6\   ���#FFFFFF �� TextAlignment$ Center=�6~   $��Center=�6�   52   +   53   '   54   #   55      56      57      � 5:      $��1��6   .+�5;      �� -   5         ��Name$ 	lv_browse��5;   #   $��Stretch=�66   $��Stretch=�6T    �� SelectionMode$ Single=�6p   $��10q�6�    �� View 5<      �� 5=   "    �� AllowsColumnReorder .  P�5>   &   �� 5?   *   $��	Product #��6b    �� Width$	 200��6u    �� DisplayMemberBinding 69   �� *itemNo+6u   �� 5@   *   $
��Item��6d   $	 300��6r    69   �� *
itemName+6r   5B   #   5D      5E      5G      5H      5I      � 5L   
   $��2��6   $��0��6   $��2��6,   .+�5M      � $��2��6   .+�5N      (� $ Uniform=�6   $��2��6,   .��5O      �� $	��210��6   $	��290��6)   .+�5P      �� $	 Vertical=�6%   $��10q�6<   .+�5R      �� $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5S   "   �� $��Item Number��6,   $
��Left=�6?   $
��Bold"�6Z   $��5(�6l   $��5 0 0 0q�6y   �� 5T   "   -   5         ��Name$ itemNo��5T   *   $��1q�6{   $��2 0 0 0q�6�   $��Microsoft Tai Le)�6�   $��8(�6�   
�������$��20��6�   $	��190��6�   $��Center=�6�   ��6:   ��  �� ElementName$ 	lv_browse�� �� Path$ SelectedItem.itemNo�6  5U      �� 5X      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5Y   "   �� $��Item Description��6,   $
��Left=�6D   $
��Bold"�6_   $��5(�6q   $��5 10 0 0q�6~   �� 5Z   "   -   5        $ itemName��5Z   *   $��1q�6<   $��Microsoft Tai Le)�6P   $��8(�6n   
�������$��2 0 0 0q�6�   $��20��6�   $	��190��6�   $��Center=�6�   5[      �� 5^      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5_   "   �� $��Brand��6,   $
��Left=�69   $
��Bold"�6T   $��5(�6f   $��5 10 0 0q�6s   �� 5`   "   -   5        $ 	itemBrand��5`   *   $��1q�6=   $��Microsoft Tai Le)�6Q   $��8(�6o   
�������$��2 0 0 0q�6�   $��20��6�   $	��190��6�   $��Center=�6�   5a      �� 5d      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5e   "   �� $"��Suggested Retail Price (SRP)��6,   $
��Left=�6P   $
��Bold"�6k   $��5(�6}   $��5 10 0 0q�6�   �� 5f   "   -   5        $ itemSRP��5f   *   $��1q�6;   $��Microsoft Tai Le)�6O   $��Regular"�6m   
�������$��2 0 0 0q�6�   $��8(�6�   $��20��6�   $	��190��6�   $��Center=�6�   5g      �� 5j      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5k   "   �� $��Retail Price (RP)��6,   $
��Left=�6E   $
��Bold"�6`   $��5(�6r   $��5 10 0 0q�6   �� 5l   "   -   5        $ itemRP��5l   *   $��1q�6:   $��Microsoft Tai Le)�6N   $��8(�6l   
�������$��2 0 0 0q�6�   $��20��6�   $	��190��6�   $��Center=�6�   5m      �� 5p      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5q   "   �� $��Value Added Tax (VAT)��6,   $
��Left=�6I   $
��Bold"�6d   $��5(�6v   $��5 10 0 0q�6�   �� 5r   "   -	   5        $ itemVAT��5r   *   $��1q�6;   $��Microsoft Tai Le)�6O   $��8(�6m   
�������$��2 0 0 0q�6�   $��20��6�   $	��190��6�   $��Center=�6�   5s      �� 5v      $	 Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�5w   "   �� $��Product Category��6,   $
��Left=�6D   $
��Bold"�6_   $��5(�6q   $��5 10 0 0q�6~   �� 5x   "   -
   5        $ itemCategory��5x   *   $��1q�6@   $��Microsoft Tai Le)�6T   $��8(�6r   
�������$��2 0 0 0q�6�   $��20��6�   $	��190��6�   $��Center=�6�   5y      �� 5|      $	 
Horizontal=�6)   $��Center=�6B   $��Center=�6]   .+�5}   "   �� -   5        $ addItem��5}   )   $��0 10 5 0q�6:   $��15��6L   ���#29CC97���#29CC97.��5~   &   �� $	 
Horizontal=�61   $
��Left=�6J   .+�5   *   �� $��Approve��64   $��SemiBold"�6C   $��5(�6Y   ���#FFFFFF$ Center=�6{   $��Center=�6�   5�   '   5�   #   �� 5�   "   -   5        $ addIem��5�   )   $��0 10 0 0q�69   $��15��6K   ���#E86845���	#FFFF6C6C.��5�   &   �� $	 
Horizontal=�61   $
��Left=�6J   .+�5�   *   �� $
��Deny��64   $��SemiBold"�6@   $��5(�6V   ���#FFFFFF$ Center=�6x   $��Center=�6�   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      