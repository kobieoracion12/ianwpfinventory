   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols'NavigationDrawerPopUpMenu2.usercontrols  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7    1NavigationDrawerPopUpMenu2.usercontrols.usc_stock   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:NavigationDrawerPopUpMenu2.usercontrols     5      6sys&clr-namespace:System;assembly=mscorlib     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      � ���#F5F6FA  � ColumnDefinitions  5   
   �� 5      $��70 �6   �� 5      $
��150* �6   �� 5      $
��850* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��1��6   $��2��6   .+�5      � ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ #4CA8A5��6'    � Offset$ 0Q�67   � 5      $ #45D5D5��6'   $ 1Q�67   5       5       �� 5!      $	��50* �6$   �� 5"      $
��385* �6$   �� 5#      $��* �6$   .+�5'      � $��0��6   .+�5(      � .+�5)      (�  (� Stretch$ Uniform=�6"   .��5*      �� $��Stock Inventory��6(   $
��Bold"�6?   $��10(�6Q   ���#FFFFFF$��20q�6t    �� TextAlignment$ Center=�6�   5+      5,      5-      � 50      $��1��6   .+�51      � .+�52      (� $ Uniform=�6"   $	��Top=�64   $��Center=�6L   .��53      ��  �� Orientation$ Vertical=�6)   $��Center=�6@   $��Center=�6[   .+�54   "   �� -   5        	 ��Name$	 ListViewMenu��54   +   ���#FFFFFF$��Disabled=�6V   .@�56   &   �� -   5        
 ��Name$
 stockStockin��56   3   $��35��6I   $��Center=�6U   .��57   *   �� $ 
Horizontal=�65   $��70��6N   .+�58   .   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Import=�6F   $��12��6T   �� 59   .   $ Vertical=�69   $��Center=�6P   .+�5:   2   �� $��Stock In��6<   $��SemiBold"�6L   $
 Left=�6b   $��7(�6w   $��5 0 5 0q�6�   �� 5;   2   $��
Add Stocks��6<   ���#777A80$��Regular"�6c   $
 Left=�6x   $��4(�6�   $��5 0 5 0q�6�   5<   /   5=   +   5>   '   �� 5A   &   -   5        $
 stockStockOut��5A   3   $��35��6J   $��Center=�6V   .��5B   *   �� $ 
Horizontal=�65   $��70��6N   .+�5C   .     $ Outbox=�6F   $��12��6T   �� 5D   .   $ Vertical=�69   $��Center=�6P   .+�5E   2   �� $��	Stock Out��6<   $��SemiBold"�6M   $
 Left=�6c   $��7(�6x   $��5 0 5 0q�6�   �� 5F   2   $��Remove Stock��6<   ���#777A80$��Regular"�6e   $
 Left=�6z   $��4(�6�   $��5 0 5 0q�6�   5G   /   5H   +   5I   '   �� 5L   &   -   5        $
 stockinInventory��5L   3   $��35��6M   $��Center=�6Y   .��5M   *   �� $ 
Horizontal=�65   $��70��6N   .+�5N   .     $ History=�6F   $��12��6U   �� 5O   .   $ Vertical=�69   $��Center=�6P   .+�5P   2   �� $��Stock In History��6<   $��SemiBold"�6T   $
 Left=�6j   $��7(�6   $��5 0 5 0q�6�   �� 5Q   2   $��Review Stock History��6<   ���#777A80$��Regular"�6m   $
 Left=�6�   $��4(�6�   $��5 0 5 0q�6�   5R   /   5S   +   5T   '   �� 5W   &   -   5        $
 stockoutInventory��5W   3   $��35��6N   $��Center=�6Z   .��5X   *   �� $ 
Horizontal=�65   $��70��6N   .+�5Y   .     $ History=�6F   $��12��6U   �� 5Z   .   $ Vertical=�69   $��Center=�6P   .+�5[   2   �� $��Stockout History��6<   $��SemiBold"�6T   $
 Left=�6j   $��7(�6   $��5 0 5 0q�6�   �� 5\   2   $��Review Stock History��6<   ���#777A80$��Regular"�6m   $
 Left=�6�   $��4(�6�   $��5 0 5 0q�6�   5]   /   5^   +   5_   '   5a   #   5b      5c      5d      5e      5f      5g      � 5j   
   -   5         �Name$ mainSubColumn��5j      $��2��6&   $��0��66   $��2��6C   $��10q�6T   .+�5k      ��  �� RadiusX$ 10��6    �� RadiusY$ 10��6%   
������� J� Effect 5l      3  -System.Windows.Media.Effects.DropShadowEffect  5m         RenderingBias$ Quality=�6'      Color$ 	#FF838383��6?      Opacity$	 0.2Q�6Q   5o      5p      5s      5t      