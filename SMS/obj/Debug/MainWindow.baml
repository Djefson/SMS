   M S B A M L   `   `   `  ����>  :SMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SMSSMS  5   	       SMS.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:SMS     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.4.1513, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   $	��600��5      $
��1332��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5	      � -   5        ���	#FFEEEEEE.+�5
   
   �� $	��Top=�6   .+�5      � ���	#FF0069C0$��10��6*   5      � 5      $��5,5,0,5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Facebook=�62   5      �� 5      $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ Twitter=�62   5      �� 5      $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ Github=�62   5      5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� $��30��6   $��30��6$   $��0q�6]   
���������60   Z� ��6F   Z� .��5         $ BellOutline=�6-   5!      �� 5#      $��30��6   $��30��6$   $��0q�6]   
�������$��0 0 10 0q�6{   ��60   Z� ��6F   Z� .��5$        $ Settings=�6.   5%      �� 5&      -   5         ��Name$ ButtonFechar��5&      $��30��6/   $��30��6:   $��0q�6s   
���������6F   Z� ��6\   Z� .��5'        $ Power=�6.   5(      5)      5*      5+      � 5,   
   $��
255,78,0,0q�6   .+�5-      � -   5         �Name$ GridPrincipal��5-      $��Center=�6*   $��Center=�6G   5.      � 5/   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�50      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��50   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+	   Duration$	 0:0:0.2X�.��51      � -   5        $ 
GridCursor��51      $��
0  100 0 0q�6+   ���	#FF0069C0$��10��6V   $
��Left=�6a   $��60��6|   $	��Top=�6�   52      �� 53      $��Lexicon1.jpg��6   $	��100��6*   $��Center=�67   $	��Top=�6T   �� 54      -   5        
 ��Name$
 ListViewMenu��54      $��	0,100,0,0q�6-   
�������$��Champagne & Limousines )�6X   $��18(�6�    �� SelectedIndex$ 0��6�   .@�55      �� $��60��6   .��56      �� $ 
Horizontal=�6!   .+�57        $ Teacher=�62   $��29��6A   $��30��6L   $��Center=�6X   $��5q�6s   $��Champagne & Limousines )�6~   �� 58      $��Teachers��6$   $��17(�65   $��Center=�6C   $
��20 0q�6^   59      5:      �� 5<      $��60��6   .��5=      �� $ 
Horizontal=�6!   .+�5>        $ Register=�62   $��30��6C   $��30��6N   $��Center=�6Z   $��5q�6u   $��Champagne & Limousines )�6�   �� 5?      $��Students��6$   $��17(�65   $��Center=�6C   $
��20 0q�6^   5@      5A      �� 5C      $��60��6   .��5D      �� $ 
Horizontal=�6!   .+�5E        $ 	AbTesting=�62   $��30��6C   $��30��6N   $��Center=�6Z   $��5q�6u   $��Champagne & Limousines )�6�   �� 5F      $
��Exam��6$   $��17(�61   $��Center=�6?   $
��20 0q�6Z   5G      5H      �� 5J      $��60��6   .��5K      �� $ 
Horizontal=�6!   .+�5L        $ 	CheckBold=�62   $��30��6C   $��30��6N   $��Center=�6Z   $��5q�6u   $��Champagne & Limousines )�6�   �� 5M      $��
Attandance��6$   $��17(�67   $��Center=�6E   $
��20 0q�6`   5N      5O      �� 5Q      $��60��6   $	��257��6+   .��5R      �� $ 
Horizontal=�6!   $	��184��6:   .+�5S        $ 
FileReport=�62   $��30��6D   $��30��6O   $��Center=�6[   $��5q�6v   $��Champagne & Limousines )�6�   �� 5T      $��Reports��6$   $��17(�64   $��Center=�6B   $
��20 0q�6]   5U      5V      �� 5X      $��60��6   .��5Y      �� $ 
Horizontal=�6!   .+�5Z        $ Settings=�62   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   $��Champagne & Limousines )�6   �� 5[      $��Admin��6$   $��17(�62   $��Center=�6@   $
��20 0q�6[   5\      5]      5_      5a      5c      5d      