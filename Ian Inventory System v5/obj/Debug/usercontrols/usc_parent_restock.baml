   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      @    :NavigationDrawerPopUpMenu2.usercontrols.usc_parent_restock   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      .��5      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��110* �6   �� 5      $
��500* �6   .+�5   
   � $��2��6   .+�5      � .+�5      �� $��
10 10 10 0q�6    �� RadiusX$ 8��60    �� RadiusY$ 8��6<   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6+      Color$ 	#FF838383��6C      Opacity$	 0.2Q�6U   5      � 5      $��10q�6   .+�5       (�  (� Stretch$ Uniform=�6   $��10q�60   .��5!      �� 	 �� Orientation$	 Vertical=�6%   $
��Left=�6<   .+�5"      �� $��Product Entry:��6$   �� 5#      -   5        
 ��Name$
 entrySearch��5#   &   $��Stretch=�6;   $��Microsoft Tai Le)�6Z   $��15(�6x   $��40��6�   $	��700��6�   $��	25 0 25 0q�6�   
�������6�   5$      5%      5&      5(      5)      � 5+   
   $��1��6   $��2��6   .+�5,      � .+�5-      �� $��10q�6   $ 8��6(   $ 8��64   
������� 5.        5/      $ Quality=�6+   $ 	#FF838383��6C   $	 0.2Q�6U   51      � 53      $��20q�6   .+�54      �   55      �� 56      $��* �6/   �� 57      $��* �6/    5:      �� 5;      $
��363* �6,   �� 5<      $	��31* �6,   �� 5=      $	��41* �6,   .+�5@      � $��0��6   .+�5A      � .+�5B   "   (� $ Uniform=�6*   $	��Top=�6<   .��5C   &   �� $	 Vertical=�61   .+�5D   *   �� $��Item Description��60   $��SemiBold"�6K   $��15(�6a   
���   �$��	20 10 0 0q�6�   �� 5E   *   -   5        $
 restockItem��5E   2   $��Stretch=�6G   $��Microsoft Tai Le)�6e   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������{�.  $	��360��6�   �� 5G   *   $��Brand��60   $��SemiBold"�6@   $��15(�6V   
���   �$��	20 15 0 0q�6w   �� 5H   *   -   5        $
 restockBrand��5H   2   $��Stretch=�6H   $��Microsoft Tai Le)�6g   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������{�.  6�   �� 5J   *   $"��Quantity (In Stock / To Add)��60   $��SemiBold"�6W   $��15(�6m   
���   �$��	20 15 0 0q�6�   �� 5K   *   $	 
Horizontal=�65   .+�5L   .   �� -   5        $
 onrestockQty��5L   6    �� 
IsReadOnly .  �� TextAlignment$ Center=�6^   $
��Left=�6u   $	��200��6�   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������{�.  6�   �� 5M   .   $��+��64   $��SemiBold"�6@   $��15(�6V   
���   �6d   �� 5N   .   -   5        $
 
restockQty��5N   6   $ Center=�6J   $��Right=�6a   $	��100��6}   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������6�   5O   +   �� 5Q   *   $!��Sugested Retail Price (SRP)��60   $��SemiBold"�6V   $��15(�6l   
���   �$��	20 15 0 0q�6�   �� 5R   *   -   5        $
 
restockSRP��5R   2   $��Stretch=�6F   $��Microsoft Tai Le)�6e   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������{�.  6�   5S   '   5T   #   5U      5V      � 5X      $��1��6   .+�5Y      � .+�5Z   "   (� $ Uniform=�6*   $	��Top=�6<   .��5[   &   �� $	 Vertical=�61   .+�5\   *   �� $��Value Added Tax (VAT)��60   $��SemiBold"�6P   $��15(�6f   
���   �$��	20 15 0 0q�6�   �� 5]   *   -   5        $
 
restockVAT��5]   2   $��Stretch=�6F   $��Microsoft Tai Le)�6e   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������{�.  $	��362��6�   �� 5_   *   $��Retail Price (RP)��60   $��SemiBold"�6L   $��15(�6b   
���   �$��	20 10 0 0q�6�   �� 5`   *   -   5        $
 	restockRP��5`   2   $��Stretch=�6E   $��Microsoft Tai Le)�6c   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������{�.  6�   �� 5b   *   $��Category��60   $��SemiBold"�6C   $��15(�6Y   
���   �$��	20 10 0 0q�6z   �� 5c   *   -	   5        $
 restockCategory��5c   2   $��Stretch=�6K   $��Microsoft Tai Le)�6i   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������{�.  6�   �� 5e   *   $��Date of Arrival��60   $��SemiBold"�6J   $��15(�6`   
���   �$��	20 15 0 0q�6�   (  "System.Windows.Controls.DatePicker  5f   *   -
   5          Name$ 
restockDOA��5f   5   $��Stretch=�6�   $��Microsoft Tai Le)�6  $��15(�62  $��30��6@  $��	25 0 25 0q�6M  
�������{�.     Text 6I   ��  �� Today �� Source# Z  �� StringFormat$ {0:dddd, MMMM dd, yyyy}�� +� FocusedElement 6�   ��  �� RelativeSource �� *Self+6s  5g   '   5h   #   5i      5j      � 5l      $��1��6   $��2��6,   .+�5m      � .+�5n   "   �� $	 
Horizontal=�6-   $��Center=�6F   $��Center=�6a   $��2��6~   .+�5o   &   (� .��5p   *   �� -   5         ��Name$ submitBrand��5p   1   $��Update��6F   ���#54b971$��Center=�6l   $��Center=�6�   6�   5q   '   (� 5r   &   $��10 0 0 0q�6.   .��5s   *   �� -   5        $ submitCancel��5s   1   $��Cancel��6H   ���#e86845$��Center=�6n   $��Center=�6�   6�   5t   '   5u   #   5v      5w      5x      5y      5z      5{      5      5�      