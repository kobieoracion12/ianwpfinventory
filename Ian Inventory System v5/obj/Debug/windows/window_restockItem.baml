   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   U QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:NavigationDrawerPopUpMenu2.windows"NavigationDrawerPopUpMenu2.windows 5   	   ;   5NavigationDrawerPopUpMenu2.windows.window_restockItem   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   Blocal0clr-namespace:NavigationDrawerPopUpMenu2.windows     5   	     � Title$  window_restockItem��5	   	   $	��600��6$   $
��1080��61    � WindowStartupLocation$ CenterScreen=�6>   .��5      � ���#F6F7FB � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��68* �6   �� 5      $
��217* �6   .+�5   
   � $��0��6   $��0��6   .+�5      � .+�5      �� $��10q�6    �� RadiusX$ 8��6(    �� RadiusY$ 8��64   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         RenderingBias$ Quality=�6+      Color$ 	#FF838383��6C   	   Opacity$		 0.2Q�6U   5      � 5      $��10q�6   .+�5       �� $��Product Entry:��6   $��	20 10 0 0q�65   �� 5!      -   5        
 ��Name$
 entrySearch��5!      $��Stretch=�63   $��Microsoft Tai Le)�6R   $��15(�6p   $��40��6~   $��
25 20 25 0q�6�   
�������6�   5"      5#      5$      � 5'   
   $��0��6   $��1��6   $��2��6,   .+�5(      � .+�5*      �� $��
10,0,10,20q�6   $ 8��60   $ 8��6<   
������� 5+        5,      $ Quality=�6+   $ 	#FF838383��6C   $		 0.2Q�6U   5.      � 51      $��10q�6   .+�52      �  53      �� 54      $��* �6/   �� 55      $��* �6/    58      �� 59      $
��343* �6,   �� 5:      $	��42* �6,   �� 5;      $	��29* �6,   .+�5?      � $��10q�6   $��0��6+   .+�5@      � .+�5A   "   ��  �� Orientation$ Vertical=�6-   .+�5B   &   �� $��Item Description��6,   $��SemiBold"�6G   $��15(�6]   
���   �$��	20 10 0 0q�6~   �� 5C   &   -   5        $
 restockItem��5C   .   $��Stretch=�6C   $��Microsoft Tai Le)�6a   $��15(�6   $��30��6�   $��	25 0 25 0q�6�   
�������6�   �� 5D   &   $��Brand��6,   $��SemiBold"�6<   $��15(�6R   
���   �$��	20 15 0 0q�6s   �� 5E   &   -   5        $
 restockBrand��5E   .   $��Stretch=�6D   $��Microsoft Tai Le)�6c   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������6�   �� 5G   &   $"��Quantity (In Stock / To Add)��6,   $��SemiBold"�6S   $��15(�6i   
���   �$��	20 15 0 0q�6�   �� 5H   &   $ 
Horizontal=�61   .+�5I   *   �� -   5        $
 onrestockQty��5I   2    �� 
IsReadOnly .  �� TextAlignment$ Center=�6Z   $
��Left=�6q   $	��200��6�   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������6�   �� 5J   *   $��+��60   $��SemiBold"�6<   $��15(�6R   
���   �6`   �� 5K   *   -   5        $
 
restockQty��5K   2   $��0��6F   $ Center=�6O   $��Right=�6f   $	��100��6�   $��Microsoft Tai Le)�6�   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������6�   5L   '   �� 5N   &   $!��Sugested Retail Price (SRP)��6,   $��SemiBold"�6R   $��15(�6h   
���   �$��	20 15 0 0q�6�   �� 5O   &   -   5        $
 
restockSRP��5O   .   $��Stretch=�6B   $��Microsoft Tai Le)�6a   $��15(�6   $��30��6�   $��	25 0 25 0q�6�   
�������6�   5P   #   5Q      5R      � 5U      $��10q�6   $��1��6+   .+�5V      � .+�5W   "   �� $ Vertical=�6-   .+�5X   &   �� $��Retail Price (RP)��6,   $��SemiBold"�6H   $��15(�6^   
���   �$��	20 10 0 0q�6   �� 5Y   &   -   5        $
 	restockRP��5Y   .   $��Stretch=�6A   $��Microsoft Tai Le)�6`   $��15(�6~   $��30��6�   $��	25 0 25 0q�6�   
�������6�   �� 5Z   &   $��Date of Arrival��6,   $��SemiBold"�6F   $��15(�6\   
���   �$��	20 15 0 0q�6}   (  "System.Windows.Controls.DatePicker  5[   &   -   5          Name$ 
restockDOA��5[   1   $��Stretch=�6�   $��Microsoft Tai Le)�6  $��15(�6.  $��30��6<  $��	25 0 25 0q�6I  
�������   Text 6E   ��  �� Today �� Source# Z  �� StringFormat$ {0:dddd, MMMM dd, yyyy}�� +� FocusedElement 6�   ��  �� RelativeSource �� *Self+6\  �� 5\   &   $��Expiration Date��6,   $��SemiBold"�6F   $��15(�6\   
���   �$��	20 15 0 0q�6}     5]   &   -	   5        $ restockEXPD��5]   1   $��Stretch=�6F   $��Microsoft Tai Le)�6e   $��15(�6�   $��30��6�   $��	25 0 25 0q�6�   
�������6�   5^   #   5_      5`      � 5b      $��5q�6   $��0��6*   $��1��6:   $��2��6G   .+�5c      �  5d   "   �� 5e   &   $��0* �64   �� 5f   &   .+�5h   "   �� $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6a   $��422,0q�6~   $��2��6�   .+�5i   &   (� .��5j   *   �� -
   5         ��Name$ submitBrand��5j   1   $��Update��6F   ���#54b971$��Center=�6l   $��Center=�6�   6�   5k   '   (� 5l   &   $��10 0 0 0q�6.   .��5m   *   �� -   5        $ submitCancel��5m   1   $��Cancel��6H   ���#e86845$��Center=�6n   $��Center=�6�   6�   5n   '   5o   #   5p      5q      5t      5u      5x      5y      5}      5~      