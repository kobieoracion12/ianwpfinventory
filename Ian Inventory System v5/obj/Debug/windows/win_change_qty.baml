   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:NavigationDrawerPopUpMenu2.windows"NavigationDrawerPopUpMenu2.windows  5   	   7    1NavigationDrawerPopUpMenu2.windows.win_change_qty   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:NavigationDrawerPopUpMenu2.windows     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Change Quantity��5
   	   $	��160��6!   $	��400��6.    � 
ResizeMode$ NoResize=�6:   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��
0 100 10 0q�6I   .+�5      �� $y�Hidden=�6   $��selected Id��6(   �� 5      -   5         ��Name$ 
selectedId��5   A   $y�Hidden=�6    �� TextAlignment$ Center=�6*   $��1q�6U   ���#BFC2C9$��Microsoft Tai Le)�6   $��2q�6�   $��13(�6�   $	��300��6�   $��30��6�   $��
10 0 10 10q�6�   6�   �� 5      $��datainventory Qty��6   $y�Hidden=�60   �� 5      -   5        $ inventoryQty��5   -   $ Center=�6   $��1q�6C   ���#BFC2C9$��Microsoft Tai Le)�6m   $��2q�6�   $��13(�6�   $	��300��6�   $��30��6�   $��
10 0 10 10q�6�   $y�Hidden=�6�   �� 5      $y�Hidden=�6   $��selected prod#��6(   �� 5      -   5        $ 
prodNumber��5   A   $y�Hidden=�6   $ Center=�6*   $��1q�6U   ���#BFC2C9$��Microsoft Tai Le)�6   $��2q�6�   $��13(�6�   $	��300��6�   $��30��6�   $��
10 0 10 10q�6�   5      �� 5   
   $ Vertical=�6   .+�5      �� $��Quantity to Return��6   $��5 0 0 0q�61   (� 5      $
��Left=�6   .��5      �� -   5        $ 
currentQty��5   1   $ Center=�6   $��1q�6E   ���#BFC2C9$��Microsoft Tai Le)�6o   $��2q�6�   $��13(�6�   $	��300��6�   $��30��6�   $��
10 0 10 10q�6�   6�   5      5      �� 5   
   -   5         ��Name$ confirmButton��5      $��Bottom=�6(   $��Confirm [Enter] ��6C   $��
15 0 15 15q�6^   ���#54b9716�   5      5       