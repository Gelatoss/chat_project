   M S B A M L   `   `   `  ����  Chat    Chat.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $	��540��5   	   $	��960��5   	   $	��540��5	   	   $	��960��5
   	   ���#255672  � WindowStyle$
  None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��50 �6   .+�5   
   �� -   5        $��0��5      $��3��6   ���#105983._�5       � $��Stretch=�6   .+�5!      �� $
��Left=�6    �� Orientation$ 
Horizontal=�5"      .+�5$      �� $��20��6   $��20��6'   $��Icons/mc.png��5%      $��
6, 0, 0, 0q�5&      �� 5(      $��
MaggieChat��6   
�������$��SemiBold"�5*      $��0,0,0,-1q�5+      5,      �� 5.      $��Right=�6   $ 
Horizontal=�5/      .+�51      �� -   5        $��20��51      $��20��6(   $��_��52      $��15(�53      
������ $��0q�55      
���   �$
��Bold"�57      $��0,-9,0,0q�58      59      �� 5;      -   5        $��20��5;      $��20��6(   $	��□��5<      $��15(�5=      
������ $��0q�5?      
���   �$
��Bold"�5A      $��0,-3,0,0q�5B      5C      �� 5E      -   5        $��20��5E      $��20��6(   $	��✕��5F      $��9(�5G      
������ $��0q�5I      
���   �$
��Bold"�5K      $��0q�5L      $��0,0,3,0q�5M      5N      5O      5P      5Q      �� 5S   
   $��1��6   $��3��6   ���#0E3952._�5V      �� $
��Left=�6   $ 
Horizontal=�5W      .+�5X      �� $��15��6   $��15��6#   $��./Icons/mc.png��5Y      $��
6, 0, 6, 0q�5Z      �� 5\      $
��Help��6      ModernButton#��[  5]       � ToolTip 5^      �� 5_      .+�5`      �� $
��Bold"�6(   $��14(�6:   $��0,0,0,5q�6H   Help6_   �� 5a       I also need help, don't worry!�� 5c   "   May God help us!5e      �� 5f      ���#0E3952$��0,1,0,0q�6;   $	��0,8q�6U   � 5g      .+�5h   "   �� $3��-/WpfTutorialSamples;component/Images/help.png��6(   $��0,0,5,0q�6_   �� 5i   "   $��Italic$�6,   Press F1 for more help6W   5j      5k      5m      �� 5o      $��About��6   #��[  5p       5q      �� 5r      .+�5s      �� $
��Bold"�6(   $��14(�6:   $��0,0,0,5q�6H   About the program6l   �� 5t      *(This is like ChatGPT, but at second hand�� 5v   "   #!Contact: blabla@student.saxion.nl�� 5x   "   Phone: +40 1112 334 4545z      5{      5}      �� 5      -   5        $	��Fun��5      #��[  5�       5�      �� 5�      .+�5�      �� $
��Bold"�6(   $��14(�6:   $��0,0,0,5q�6H   Funny Button6g   �� 5�      This is supposed to be funny5�      5�      5�      5�      5�      � 5�   
   $��3��6   $��1��6    5�      �� 5�      �� 5�      $��90 �6#   .+�5�      �� -   5         ��Name$ Input��5�      $��30��5�      $��2��5�      $��8q�5�        ModernTextBox#��[ 5�      �� 5�      -   5        $��1��5�      $��0,0,16,0q�5�      $��20��5�      $��20��6    $��Right=�5�      
������ $��0q�5�      
���������5�      �� 5�      $��./Icons/send.png��6   $��20��65   $��20��6@   5�      5�      � 5�   
   $��2��6   $��3��6   ��5�      �� 5�       �� ImageSource$ ./Icons/background.png��6   	 �� Opacity$
	 0.35Q�5�      
 j� Stretch$
 Uniform=�5�      .+�5�      �� -   5         ��Name$ ChatScrollViewer��5�      $
��Auto=�65   .��5�      � .+�5�      �� -	   5         ��Name$ AddStackPanel��5�   !   
������ $��15q�5�   !   5�      5�      �� 5�      -
   5         ��Name$ FunImage��5�      $y�	Collapsed=�6&   5�      5�      5�      