   M S B A M L   `   `   `  ����>  :SMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SMSSMS  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5	          SMS.UserControlLogin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:SMS     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.4.1513, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5dragblz'http://dragablz.net/winfx/xaml/dragablz  5      XThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  5	      $	��465��5
       $��994.5��6-   $��Center=�6;   $��Center=�6V   .��5      � $��
0,0,108,10q�6     � ColumnDefinitions  5   
   �� 5      $
��410* �6   �� 5      $	��42* �6   �� 5       � RowDefinitions 5   
   �� 5      $
��265* �6   �� 5      $	��81* �6   �� 5      $
��115* �6   .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��5   .   $��3��6�   $��Expanded&�6�   $	��451��6�   $	��Top=�6�   $��
104,0,10,0q�6�   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      � $��10,10,1000,-10q�6     5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      � $��-102,10,-873,16q�6   $��3��61    5       �� 5!      $
��314* �6(   �� 5"      $
��219* �6(     5$      �� 5%      $
��739* �6+   �� 5&      $
��419* �6+   ��5(      �� 5)       �� 
StartPoint$ 0.1,0&�6.    �� EndPoint$ 0.9,1&�6A   .��5*      �  � Color$ 	#FFE63070��6+    � Offset$ 1Q�6=   � 5+      $ 	#FFFE8704��6+   $ 0Q�6=   5,      .+�5.      �� 	 �� CornerRadius$	 	0 0 350 0��6   
���   �$��2��6J   $��
0,-13,0,72q�6^   $��2��6r   � 50      $��
10,0,381,0q�6   $��2��6/   �� 51      
 �� Orientation$
 
Horizontal=�6!   $��20,-22,122,0q�6:   $��2��6P   $��2��6d   .+�52      �� $	��350��6%   .+�53      �� $��Icons/LexLogo.png��6$   $	��123��6?   $	��Top=�6L   $��10,25,189,25q�6d   $
��Fill=�6z   56      �� 57      $	��536��6%   $��0,0,0,10q�61   .+�58      �� $��User  Login��6(   $��39,20,234,20q�6;   
������� �� TextAlignment$ Center=�6d   $��40(�6{   $��Matura MT Script Capitals)�6�   $��58��6�   �� 59      $
 
Horizontal=�6)   $��10,10,159,10q�6B   .+�5:   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6:   $��30��6F   $��40��6Q   
�������6]   �� 5;   "   -   5         ��Name$ txtUsername��5;   *   $
��10 0q�6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Username/Email��6M   
�������$	��329��6�   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD944486�   5<      �� 5>      $
 
Horizontal=�6)   $��10,10,159,10q�6B   .+�5?   "     $
 Lock=�6:   $��30��6F   $��40��6Q   
�������6]   G� 5@   "   -   5         G�Name$ txtPassword��5@   .   $
��10 0q�6C   $ ***********************��6Q   
�������$	��325��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944486�   5A      �� 5B      $��10q�6)   $��Center=�65   .+�5C   "   �� -   5         ��Name$ btnLogin��5D   �   $	��223��5C   )   $��51��65      MaterialDesignRaisedButton#��[  6A   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5D   "   $��2q�6P   ���#D94448���#D94448
������� � ToolTip$ Login��6�   $��Login��6�   5E      5G      �� 5H      $��98��6%   .+�5I      �� -   5        $ btnExit��5I   �   $��-98,20,152,20q�6%    & "MaterialDesignFloatingActionButton#��[ 6<   $ Close��6�   $
��Auto��6�   $��39��6�   ��6x   Z� .��5J   "     $ Close=�6:   
�������$��30��6Z   $��30��6e   5M      5O      5Q      5R      5S      5T      5U      5W      