   M S B A M L   `   `   `  ����E  ATalanaSera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TalanaSera
TalanaSera  5   	   F BLottieSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:LottieSharp;assembly=LottieSharpLottieSharp 5   	       TalanaSera.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TalanaSera     5   	   Flottiesharp.clr-namespace:LottieSharp;assembly=LottieSharp     5   	     � Title$  
MainWindow��5	   	   $
��1500��6   $
��1800��6*    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M    � WindowStyle$
 None=�6r    � WindowState$ 	Maximized=�6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��1* �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $	��128 �6    �� 5      $��1* �6    .+�5      � $��0��6   
���   � 5      �� 5      $	��380 �6'   �� 5      $��1* �6'   �� 5      $	��200 �6'   .+�5      �� -   5         ��Name$ cizgi��5      
�������$��0��6?   $��4��6O   $
��Left=�6Y   �� 5      -   5        $ profilim��5       �� Orientation$ 
Horizontal=�6/   $��50,0,0,0q�6H   .+�5      �� 	 �� RadiusX$		 120��6    
 �� RadiusY$	
 120��6.   $
��20,5q�5       $
��Left=�5!      $	��100��5"      $	��100��5#      ��5$      �� 5%      -   5        myImage�� �� ImageSource$ Images/profil.jpg��5%   :   5'      �� 5(      $ Vertical=�6!   .+�5)      �� -   5         ��Name$ hasan��5)       $��HASAN AYDINER��6/   
�������$��0,30,0,0q�6Z   $��23(�6l   $��SemiBold"�6z   �� 5*      -   5        $ hatali��5*       $#��Son hatalı giriş dün 19:52��60   
�������$��Center=�6h   �� 5+      -   5        $ kirmiziCizgi��5+   %   
���  ��$��2��6L   $��	22,0,21,0q�6W   5,      5-      �� 5.      $��2��6   $��Images/wifi.png��6(   $��10q�6A   5/       � 51      -   5          �Name$ 	ortaPanel��51   7     � NavigationUIVisibility$ Hidden=�6   $��1��6J   53      55      � 57   
   $��0��6   ��58      �� 59       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5:      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5;      $ 	#FF6C6C6C��6#   $ 1Q�65   � 5<      $ 	#FF474747��6#   $
 0.63Q�65   5=       5?      �� 5@      $	��150 �6    �� 5A      $	��250 �6    �� 5B      $��2* �6    �� 5C      $	��150 �6    .+�5E      �� $��Images/Logo.png��6   $��0��6-   �� 5I      $��1��6   $��0,90,0,0q�6(   $��2��6:   $��Hidden=�6K   $��Hidden=�6r   .��5J      �� -   5        $ menular��5J      $ Vertical=�6.   $��Center=�6E   $	��300��6b   $��Stretch=�6n   .+�5K      �� 
�������$��1��64   $	��200��6?   $��Center=�6K    J� Opacity$	 0.2Q�6h      TalanaSera.MenuItem  5L      -	   5          Name$ bildirim��5L   �      TalanaSera.MenuItem   
MouseEnter$ bildirim_MouseEnter��6h      
MouseLeave$ bildirim_MouseLeave��6�      MouseLeftButtonDown$" bildirim_MouseLeftButtonDown��6�      arkaplan
 ���� $	��170��6<   $	��300��6I   	   ad$ Bildirimlerim��6U   
   yol$ Images/uyari33.png��6�   6�   �� 5M      
�������$��1��65   $	��200��6@   $��Center=�6L   $	 0.2Q�6i     5N      -
   5        $ 	Seralarim��5N   �   $ Seralarim_MouseEnter��6v   $ Seralarim_MouseLeave��6�   $# Seralarim_MouseLeftButtonDown��6�   
 ���� $	��170��6<   $ 
Seralarım��6I   $ Images/greenhouse2.png��6X   6�   �� 5O      
�������$��1��65   $	��200��6A   $��Center=�6M   $	 0.2Q�6j     5P      -   5        $ grafik��5P   <   $ grafik_MouseEnter��6�   $ grafik_MouseLeave��6�   $  grafik_MouseLeftButtonDown��6�   
 ���� $	��170��6L   $ Analiz ve Önerilerimiz��6Y   $ Images/grafik1.png��6u   6�   �� 5Q      
�������$��1��65   $	��200��6A   $��Center=�6M   $	 0.2Q�6j     5R      -   5        $ hesabim��5R   <   $ hesabim_MouseEnter��6�   $ hesabim_MouseLeave��6�   $! hesabim_MouseLeftButtonDown��6�   
 ���� $	��170��6M   $ Hesabım��6Z   $ Images/profil2.png��6g   6�   �� 5S      
�������$��1��65   $	��200��6A   $��Center=�6M   $	 0.2Q�6j   5T      5U      5X      5Z      5[      