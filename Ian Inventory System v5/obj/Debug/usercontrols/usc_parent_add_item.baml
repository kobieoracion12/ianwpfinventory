   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      U QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols 5      A   ;NavigationDrawerPopUpMenu2.usercontrols.usc_parent_add_item   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Alocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols  5      .��5      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��110* �6   �� 5      $
��500* �6   .+�5   
   � $��2��6   .+�5      � .+�5      �� $��
10 10 10 0q�6    �� RadiusX$ 8��60    �� RadiusY$ 8��6<   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6+      Color$ 	#FF838383��6C      Opacity$	 0.2Q�6U   5      � 5      $��10q�6   .+�5      (�  (� Stretch$ Uniform=�6   $��10q�60   .��5       �� 	 �� Orientation$	 Vertical=�6%   $
��Left=�6<   .+�5!      �� $��Product Code (Barcode):��6$   �� 5"      -   5        
 ��Name$
 checkBarcode��5"   &   $��Stretch=�6<   $��Microsoft Tai Le)�6[   $��15(�6y   $��40��6�   $	��700��6�   $��	25 0 25 0q�6�   
�������6�   5#      5$      �� 5%      -   5        $
 checker��5%      $��Microsoft Tai Le)�6/   $��10(�6M   $	��300��6[   $��10 20 10 10q�6g   
�������$y�Hidden=�6�   5&      5(      5+      � 5-   
   $��1��6   $��2��6   .+�5.      � .+�5/      �� $��10q�6   $ 8��6(   $ 8��64   
������� 50        51      $ Quality=�6+   $ 	#FF838383��6C   $	 0.2Q�6U   53      � 55      $��20q�6   .+�56      �   57      �� 58      $��* �6/   �� 59      $��* �6/    5<      �� 5=      $
��363* �6,   �� 5>      $	��31* �6,   �� 5?      $	��41* �6,   .+�5B      � $��0��6   .+�5C      � .+�5D   "   (� $ Uniform=�6*   .��5E   &   �� $	 Vertical=�61   .+�5F   *   �� $��Item Description��60   $��SemiBold"�6K   $��15(�6a   
���   �$��	20 10 0 0q�6�   �� 5G   *   -   5        $
 addItem��5G   2   $��Stretch=�6C   $��Microsoft Tai Le)�6a   $��15(�6   $��30��6�   $��	25 0 25 0q�6�   
�������6�   �� 5I   *   $��Brand��60   $��SemiBold"�6@   $��15(�6V   
���   �$��	20 15 0 0q�6w   �� 5J   *   -   5         ��Name$ addBrand��5J   3   $��Stretch=�6E   $��Microsoft Tai Le)�6c   $��15(�6�   $��	25 0 25 0q�6�   $��30��6�    �� 
IsEditable . 6�   �� 5L   *   $��Quantity (To Stock)��60   $��SemiBold"�6N   $��15(�6d   
���   �$��	20 15 0 0q�6�   �� 5M   *   -   5        $
 addQty��5M   2   $��Stretch=�6B   $��Microsoft Tai Le)�6a   $��15(�6   $��30��6�   $��	25 0 25 0q�6�   
�������6�   �� 5O   *   $��Purchase Price��60   $��SemiBold"�6I   $��15(�6_   
���   �$��	20 15 0 0q�6�   �� 5P   *   -   5        $
 	addRetail��5P   2   $��Stretch=�6E   $��Microsoft Tai Le)�6d   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������6�   �� 5R   *   $��Expiration Date��60   $��SemiBold"�6J   $��15(�6`   
���   �$��	20 15 0 0q�6�   $y�Hidden=�6�   �� 5S   *   $	 
Horizontal=�65   .+�5T   .   (  "System.Windows.Controls.DatePicker  $��Stretch=�69   $��Microsoft Tai Le)�6X   $��15(�6v   $��30��6�   $	��370��6�   $��	25 0 25 0q�6�   
�������$y�Hidden=�6�   5U   +   5V   '   5W   #   5X      5Y      � 5[      $��1��6   .+�5\      � .+�5]   "   (� $ Uniform=�6*   .��5^   &   �� $	 Vertical=�61   .+�5_   *   �� $��	Pricelist��60   $��SemiBold"�6D   $��15(�6Z   
���   �$��	20 10 0 0q�6{   �� 5`   *   -   5        $
 addRP��5`   2   $��Stretch=�6A   $��Microsoft Tai Le)�6_   $��15(�6}   $��30��6�   $��	25 0 25 0q�6�   
�������$	��360��6�   6�   �� 5b   *   $	 Vertical=�65   .+�5c   .   �� $��Value Added Tax (VAT %)��64   $��SemiBold"�6V   $��15(�6l   
���   �$��	20 15 0 0q�6�   �� 5d   .   -   5        $
 addVAT��5d   6   $��Stretch=�6F   $��Microsoft Tai Le)�6d   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������6�   5e   +   �� 5g   *   $��Product Category��60   $��SemiBold"�6K   $��15(�6a   
���   �$��	20 15 0 0q�6�   �� 5h   *   -	   5        $ addCategory��5h   3   $��Stretch=�6H   $��Microsoft Tai Le)�6f   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
������� . 6�   �� 5j   *   $��Date of Arrival��60   $��SemiBold"�6J   $��15(�6`   
���   �$��	20 15 0 0q�6�     5k   *   -
   5          Name$ addDOA��5k   5   $��Stretch=�6�   $��Microsoft Tai Le)�6  $��15(�6.  $��30��6<  $��	25 0 25 0q�6I  
�������   Text 6E   ��  �� Today �� Source# Z  �� StringFormat$ {0:dddd, MMMM dd, yyyy}�� +� FocusedElement 6�   ��  �� RelativeSource �� *Self+6\  �� 5m   *   $!��Sugested Retail Price (SRP)��60   $��SemiBold"�6V   $��15(�6l   
���   �$��	20 15 0 0q�6�   $y�Hidden=�6�   �� 5n   *   $��Stretch=�62   $��Microsoft Tai Le)�6Q   $��15(�6o   $��30��6}   $��	25 0 25 0q�6�   
�������$y�Hidden=�6�   5p   '   5q   #   5r      5s      � 5u      $��1��6   $��2��6,   .+�5v      � .+�5w   "   �� $	 
Horizontal=�6-   $��Center=�6F   $��Center=�6a   $��2��6~   .+�5x   &   (� .��5y   *   �� -   5         ��Name$ submitButton��5y   1   $��Submit��6G   ���#54b971$��Center=�6m   $��Center=�6�   6�   5z   '   (� 5{   &   $��10 0 0 0q�6.   .��5|   *   �� -   5        $ cancelButton��5|   1   $��Cancel��6H   ���#e86845$��Center=�6n   $��Center=�6�   6�   5}   '   5~   #   5      5�      5�      5�      5�      5�      5�      5�      