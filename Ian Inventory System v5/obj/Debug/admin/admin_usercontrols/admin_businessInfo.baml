   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      U QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:NavigationDrawerPopUpMenu2.admin NavigationDrawerPopUpMenu2.admin 5      9   3NavigationDrawerPopUpMenu2.admin.admin_businessInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5      :local.clr-namespace:NavigationDrawerPopUpMenu2.admin  5      .��5      � 
�������  � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $	��400 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��200* �6   �� 5      $��1000* �6   �� 5      $
��200* �6   .+�5   
   � $��1��6   $��1��6   .+�5      � .+�5      �� $��
0 30 20 10q�6   $��Business Information��60   $��20(�6L   $��Segoe UI Semibold)�6Z    �� TextAlignment$
 Left=�6y   $	��Top=�6�   
���   �$��27��6�   5      5      � 5    
   $��1��6   $��1��6   .+�5!      �  5"      �� 5#      $��* �6'   �� 5$      $��* �6'     5'      �� 5(      $	��40* �6$   �� 5)      $
��300* �6$   �� 5*      $	��40* �6$   .+�5-      � $��0��6   $��1��6'   .+�5.      � .+�5/      ��  �� Orientation$ Vertical=�6%   $��20 10q�6<   $��Stretch=�6K   $��Center=�6i   .+�50      �� $��Business/Company Name��6$   $��15(�6D   �� 51      -   5         ��Name$ 	accNumber��51   &   $��30��69   ���#EDEFF3$��1q�6\   �� 53      $��Branch (If Applicable)��6$   $��15(�6E   $��0 10 0 0q�6S   �� 54      -   5        $ 	firstName��54   &   $��30��69   ���#EDEFF3$��1q�6[   �� 56      $��Business Type��6$   $��15(�6<   $��0 10 0 0q�6J   �� 57      -   5        $ lastName��57   &   $��30��68   ���#EDEFF3$��1q�6Z   58      59      5:      � 5<      $��1��6   $��1��6'   .+�5=      � .+�5>      �� $ Vertical=�6%   $��20 10q�6<   $��Stretch=�6K   $��Center=�6i   .+�5?      �� $
��Left=�6)   $ 
Horizontal=�6D   .+�5@   "   �� $
��Left=�6-   .+�5A   &   �� $
��Town��6,   $��15(�6;   �� 5B   &   -   5        $ userName��5B   .   $��30��6@   $	��145��6L   ���#EDEFF3$��1q�6n   5C   #   �� 5E   "   $
��Left=�6-   $��10 0 0 0q�6H   .+�5F   &   �� $��Province/State��6,   $��15(�6E   �� 5G   &   -   5        $ userNme��5G   .   $��30��6?   $	��145��6K   ���#EDEFF3$��1q�6m   5H   #   5I      �� 5K      $
��Left=�6)   $ 
Horizontal=�6D   $��0 10 0 0q�6]   .+�5L   "   �� $
��Left=�6-   .+�5M   &   �� $��Country��6,   $��15(�6>   �� 5N   &   -   5        $ usrName��5N   .   $��30��6?   $	��145��6K   ���#EDEFF3$��1q�6m   5O   #   �� 5Q   "   $
��Left=�6-   $��10 0 0 0q�6H   .+�5R   &   �� $��Zipcode��6,   $��15(�6>   �� 5S   &   -   5        $ serNme��5S   .   $��30��6>   $	��145��6J   ���#EDEFF3$��1q�6l   5T   #   5U      �� 5W      $��Account Created��6$   $��15(�6>   $��0 10 0 0q�6L   (  "System.Windows.Controls.DatePicker  5X      -   5          Name$ accPrivilege��5X   )   $��Stretch=�6�   $��30��6
  ���#EDEFF3$��1q�6,  {�.     Text 6?   ��  �� Today �� Source# Z 	 �� StringFormat$	 {0:dddd, MMMM dd, yyyy}��
 +� FocusedElement
 6�   ��  �� RelativeSource �� *Self+6@  5Y      5Z      5[      � 5]      $��0��6   $��2��6'   $��2��64   .+�5^      � .+�5_      �� $ 
Horizontal=�6%   $��Right=�6>   $��Center=�6Z   .+�5`      �� -	   5         ��Name$ piNextButton��5`   %   $��5 5 5 10q�6;   $��25��6M   
�������.��5a   "   �� $ 
Horizontal=�6-   $
��Left=�6F   .+�5b   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ ArrowRightBold=�6>   ���#B1B1B1$��Center=�6i   5c   #   5d      5e      5f      5g      5h      5i      5j      5l      