   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   <    6NavigationDrawerPopUpMenu2.usercontrols.window_addItem   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  window_addItem��5	   	   $	��600��6    $
��1080��6-    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P    � WindowStyle$ ThreeDBorderWindow=�6u   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��1��6   .+�5      �� $��1��6   $��5��6)    �� Orientation$ Vertical=�66   .+�5      �� -   5         ��Name$ checker��5      $��1q�6,   $��Microsoft Tai Le)�6@   $��20(�6^   ���#FFFFFF$	��340��6�   $��5q�6�   $y�Hidden=�6�   5      5      �� 5   
   $��1��6   $��1��6%   $��Center=�62   .+�5      �  5       �� 5!      $��* �6'   �� 5"      $��* �6'    5$      �� 5%      $
��auto �6$   �� 5&      $
��auto �6$   �� 5'      $
��auto �6$   �� 5(      $
��auto �6$   �� 5)      $
��auto �6$   �� 5*      $
��auto �6$   �� 5+      $
��auto �6$   �� 5,      $
��auto �6$   .+�5/      �� $ Vertical=�6   .+�50      (� $��0��6   $��0��6.   $
��Left=�6;   $��Center=�6V   .��51      �� $��	PRODUCT #��6$   $��Microsoft Tai Le)�65   $
��Bold"�6S   $��20(�6e   ���#7B7873 �� Padding$ 10q�6�   $��
50 0 100 0q�6�   52      53      �� 54      $��0��6   $��1��6-   $ Vertical=�6:   .+�55      �� $��PRODUCT NAME��6    $��Microsoft Tai Le)�64   $
��Bold"�6R   $��20(�6d   ���#7B7873$ 10q�6�   $��
50 0 100 0q�6�   56      �� 57      $��0��6   $��2��6-   $ Vertical=�6:   .+�58      �� $��PRODUCT BRAND��6    $��Microsoft Tai Le)�65   $
��Bold"�6S   $��20(�6e   ���#7B7873$ 10q�6�   $��
50 0 100 0q�6�   59      �� 5:      $��0��6   $��3��6-   $ Vertical=�6:   .+�5;      �� $��Quantity��6    $��Microsoft Tai Le)�60   $
��Bold"�6N   $��20(�6`   ���#7B7873$ 10q�6�   $��
50 0 100 0q�6�   5<      �� 5=      $��0��6   $��4��6-   $ Vertical=�6:   .+�5>      �� $��SUGGESTED RETAIL PRICE��6    $��Microsoft Tai Le)�6>   $
��Bold"�6\   $��20(�6n   ���#7B7873$ 10q�6�   $��
50 0 100 0q�6�   5?      �� 5@      $��0��6   $��5��6-   $ Vertical=�6:   .+�5A      �� $��RETAIL PRICE��6    $��Microsoft Tai Le)�64   $
��Bold"�6R   $��20(�6d   ���#7B7873$ 10q�6�   $��
50 0 100 0q�6�   5B      �� 5C      $��0��6   $��6��6-   $ Vertical=�6:   .+�5D      �� $��DATE OF ARRIVAL��6    $��Microsoft Tai Le)�67   $
��Bold"�6U   $��20(�6g   ���#7B7873$ 10q�6�   $��
50 0 100 0q�6�   5E      �� 5F      $��0��6   $��7��6-   $ Vertical=�6:   .+�5G      �� $��EXPIRATION DATE��6    $��Microsoft Tai Le)�67   $
��Bold"�6U   $��20(�6g   ���#7B7873$ 10q�6�   $��
50 0 100 0q�6�   5H      �� 5K      $��1��6   $��0��6-   $
��Left=�6:   .+�5L      �� -   5        $ tbProdNo��5L      $��1q�60   $��Microsoft Tai Le)�6D   $��20(�6b   ���#FFFFFF$	��340��6�   $��5q�6�   6�   5M      �� 5N      $��1��6   $��1��6-   $ Vertical=�6:   .+�5O      �� -   5        $ 
tbProdItem��5O      $��1q�62   $��Microsoft Tai Le)�6F   $��20(�6d   ���#FFFFFF$	��340��6�   $��5q�6�   5P      �� 5Q      $��1��6   $��2��6-   $ Vertical=�6:   .+�5R      �� -   5        	 ��Name$	 tbProdBrand��5R      $��1q�64   $��Microsoft Tai Le)�6H   $��20(�6f   
�������$	��340��6�   $��5q�6�   
 �� 
IsEditable
 . .@�5S      �� $��Select��6'    �� 
IsSelected . 68   5T      5U      �� 5V      $��1��6   $��3��6-   $ Vertical=�6:   .+�5W      �� -   5        $ 	tbProdQty��5W      $��1q�61   $��Microsoft Tai Le)�6E   $��20(�6c   ���#FFFFFF$	��340��6�   $��5q�6�   5Y      �� 5Z      $��1��6   $��4��6-   $ Vertical=�6:   .+�5[      �� -   5        $ 	tbProdSRP��5[      $��1q�61   $��Microsoft Tai Le)�6F   $��20(�6d   ���#FFFFFF$	��340��6�   $��5q�6�   5\      �� 5]      $��1��6   $��5��6-   $ Vertical=�6:   .+�5^      �� -   5        $ tbProdRP��5^      $��1q�61   $��Microsoft Tai Le)�6E   $��20(�6c   ���#FFFFFF$	��340��6�   $��5q�6�   5_      �� 5`      $��1��6   $��6��6-   $ Vertical=�6:   .+�5a      (  "System.Windows.Controls.DatePicker  -   5          Name$ 	tbProdDOA��5a   !   $��1q�6�   $��Microsoft Tai Le)�6�   $��20(�6�   $��1��6�   $��5��6�   $	��340��6�   $��5q�6�      Text 64   ��  �� Today �� Source# Z  �� StringFormat$ {0:dddd, MMMM dd, yyyy}��6�   5b      �� 5c      $��1��6   $��7��6-   $ Vertical=�6:   .+�5d        -	   5        $ 
tbProdEXPD��5d   !   $��1q�65   $��Microsoft Tai Le)�6I   $��20(�6g   $��1��6u   $��5��6�   $	��340��6�   $��5q�6�   5e      5f      �� 5h      $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5i      (� $��
10 20 0 0 q�6   .��5j      �� -
   5         ��Name$ addItemSubmit��5j      $��Submit��64   ���#54b971$��Center=�6Z   $��Center=�6u   6�   5k      (� 5l      $��	10 20 0 0q�6   .��5m      �� -   5        $ addItemCancel��5m      $��Cancel��65   ���#e86845$��Center=�6[   $��Center=�6v   6�   5n      5o      5p      5t      5u      