   M S B A M L   `   `   `  ����H  DTalanaService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TalanaServiceTalanaService  5   	   ?$clr-namespace:TalanaService.NesnelerTalanaService.Nesneler  5   	       TalanaService.AnaPencere   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TalanaService     5   	   8Menuler$clr-namespace:TalanaService.Nesneler     5   	     � Title$  
AnaPencere��5	   	   $	��800��6   $
��1300��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � WindowState$ 	Maximized=�6n   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $
��107* �6   .+�5   
   � $��0��6   ���#f3f3f3 K� ZIndex$ 99999��64    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      ShadowDepth$ 6Q�61   	   
BlurRadius$	 20Q�6A   
   	Direction$
 0Q�6R      Opacity$ .6Q�6`   .+�5      �� -   5        $��Assets/Logo.png��5      $��0,10,0,0q�6]   $��80��6o   $	��Top=�6{   �� 5      $��1��6   
���   �$	��260��67    J� Opacity$ .1Q�6C   $��Center=�6P   $��20,100,20,0q�6m   $	��Top=�6�    5        5      $ Black��6'   $ 10Q�65   $	 10Q�6F   $
 90Q�6W   $ 1Q�6f   5      �� 5      $��Hidden=�6   $
��Auto=�6B   $��
0,148,0,56q�6e   .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6!   $��Right=�6:   .+�5      �� -   5         ��Name$ UserBtn��5   J   $��Center=�6     � Cursor$
 Hand��6<   $��Assets/User.png��6�   $��40��6�   $��Right=�6�   $��	0,0,30,10q�6�   �� 5      -   5        $ SeraEkleBtn��5   /   $
 Hand��6!   $��Assets/Ekle.png��6w   $��40��6�   $��Right=�6�   $��	0,0,30,10q�6�   5!      �� 5"      -   5         ��Name$ SeraListesi��5"   !   5$      5%      5&      �� 5(      
���   �$ .1Q�6,   $��
20,0,20,50q�69   $��1��6M   $��Bottom=�6X    5)        5*      $ Black��6'   $ 10Q�65   $	 10Q�6F   $	
 -90Q�6W   $ 1Q�6g   5,      �� 5-      $��Versiyon : 1.0.0��6   $��
20,0,20,15q�6/   $��24��6C   $��Center=�6O   $��Bottom=�6s   5.      � 5/   
   $��1��6   ���#f3f3f3 � RowDefinitions 50      �� 51      $��90 �6    �� 52      $
��397* �6    .+�54      � $��0��6   .+�55      �� -   5         ��Name$ degisenBaslik��55      $��
Elma Seram��6/   $ .6Q�6D   
���   �$��25(�6d   $��Center=�6r   $��30,0,0,0q�6�   �� 56       �� CornerRadius$ 15��6   
������� �� Padding$
 20 0q�6B   $��
0,10,30,10q�6Q   $��Right=�6e   ._�57      � .+�58      �� $��30��6$   $��30��60    �� RadiusX$ 30��6;    �� RadiusY$ 30��6H   $
��Left=�6U   ��59      �� 5:   "    �� ImageSource$ Assets/profil.jpg��6-   5<      �� 5=      $��Ömer Faruk ARSLAN��6    $��Right=�6<   $��Center=�6X   $��40,0,0,0q�6s   $��14(�6�   5>      5?      5@      � 5A      $��1��6   .+�5B       � -   5          �Name$ degisenPanel��5B      5D      5E      5F      5G      5H      