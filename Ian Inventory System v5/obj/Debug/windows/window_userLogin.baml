   M S B A M L   `   `   `  ����U  QNavigationDrawerPopUpMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:NavigationDrawerPopUpMenu2.windows"NavigationDrawerPopUpMenu2.windows  5   	   9    3NavigationDrawerPopUpMenu2.windows.window_userLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:NavigationDrawerPopUpMenu2.windows     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  window_userLogin��5	   	   $	��600��6"   $
��1080��6/    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R    � WindowStyle$
 None=�6w   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      � ��5      �� 5       �� ImageSource$ /assets/pos_image2.jpg��6!    j� Stretch$ UniformToFill=�6F   5      5      � 5   
   $��1��6   .+�5      �  5       �� 5!      $��50 �6$   �� 5"      $
��195* �6$   �� 5#      $��50 �6$   .+�5&      � $��0��6   .+�5'      � $��10q�6   .+�5(      ��  �� Orientation$ Vertical=�6%   $��Center=�6<   $��Center=�6Y   5*      5+      5,      � 5/      $��1��6   .+�50      � $��10q�6    51      �� 52      $��60 �6/   �� 53      $
��280* �6/   �� 54      $��60 �6/   .+�58      � $��1��6   .+�59      �� $ Vertical=�6)   $
��Left=�6@   $	��Top=�6[   .+�5:   "   (� 	 (� Stretch$	 Uniform=�6*   .��5;   &   �� $	��200��6-   $��12��69   .+�5<   *   �� $��Welcome Back!��64   $��Microsoft Tai Le)�6I   $
��Bold"�6g   $��10(�6y   ���#08234B

 �� Top$
 10��6�   5=   '   5>   #   (� 5@   "   $	 Uniform=�6*   .��5A   &   �� $	��240��6-   $��40��69   .+�5B   *   �� $3��-Please login so we can continue our business.��64   $��Microsoft Tai Le)�6i   $��Regular"�6�   $��10(�6�   ���#08234B$
 10��6�   5C   '   5D   #   5F      �� 5H      $ Vertical=�6)   $��Stretch=�6@   $��Center=�6^   .+�5J   "   �� $��Username��6(   �� 5K   "   -   5         ��Name$ txtUsername��5K   *   $��30��6?   ���#EDEFF3$��1q�6a   �� 5N   "   $��Password��6(   $��0 20 0 0q�6;   G� 5O   "   -   5         G�Name$ txtPassword��5O   .   $��30��6C   ���#EDEFF3$��1q�6e   6y   �� 5R   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5S   &   �� -   5         ��Name$ loginButton��5S   G   $��Login��6\   $
��auto��6l   $��
0 30 10 20q�6y   ��6�   �� *LoginCommand+��6�   ��  �� ElementName$ PasswordBox���� 5T   &   -   5        $ 
exitButton��5T   G   $
��Exit��6[   $
��auto��6j   $��
0 30 10 20q�6w   ��6�   �� *LoginCommand+��6�   �� $ PasswordBox��5U   #   5V      5W      5Y      5Z      � 5]      $��2��6   .+�5^      � .+�5_      �� $;��5Copyright © 2020 Freelance Devs. All Rights Reserved��6$   $��Microsoft Tai Le)�6`   $��Regular"�6~   $��20q�6�   $��Right=�6�   $��Bottom=�6�   $��10(�6�   ���#08234B6�   5`      5a      5c      5d      5f      5g      