   M S B A M L   `   `   `  ����E  ATalanaSera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TalanaSera
TalanaSera  5          TalanaSera.SeraBilgi   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:TalanaSera     5        � 	Resources  5	         ButtonStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value N� EnterActions	 W� To	 g� Duration
 �� TargetProperty N� ExitActions��%�  &	        �� 5
   
   " ��6$   .�5      ��  � �� �#60634f6+    5      P� 5       �@J�IsMouseOver .  5      �� 5      .��5      �� .��5   "   W� $	 0.1X�62   $	 0:0:0.5D�6;   $
 Opacity�6N   W� 5   "   $	 0.5X�62   $	 0:0:1D�6;   $
 Opacity�6L   5      5       5      �� 5      .��5      �� .��5   "   W� $ 1X�62   $	 0:0:0.5D�69   $
 Opacity�6L   5      5      5      5      5       .��5!      �� -   5         ��Name$ arkarenk��5!      #��[  6   $	��500��6D   $	��200��6P   $	��Top=�6]   $
��Left=�6u   ���#e0eeee �� CornerRadius$ 10,100,100,10��6�   $��78,18,18,18q�6�   ���#1c0f45$��6q�6�    J� Effect 5"   
   3  -System.Windows.Media.Effects.DropShadowEffect  5#         Opacity$ 1Q�5$         
BlurRadius$ 10Q�5%         RenderingBias$ Quality=�5&         ShadowDepth$ 5Q�5'         Color$ Black��6%   ._�5)   
   �  � ColumnDefinitions 5*      �� 5+      $	��200 �6#   �� 5,      $	��300 �6#   .+�5.      �� -   5         ��Name$ resim��5.      $��Images/derece1.png��6#   $��0��6?   $	��150��6O   $	��150��6\   � 5/      $��1��6   $
��Left=�6#   .+�50      �� $	��300��6   $	��200��6&   ���#1c0f45$��6,0,0,0q�6I   $	 100��6c   $��0,-5,0,0q�6v   ._�51      � .+�52      �� $
��Left=�6   $��Center=�69    �� Orientation$ 
Horizontal=�6T   $��
30,27,0,52q�6m   $	��109��6�   .+�53      �� -   5         ��Name$
 isim��53      $��↑ 25 ��6"   $��1��62   $��0q�6B   $��50(�6N   ���#000080$��SemiBold"�6q   �� 54      -   5        $ isim2��54      $	��°C��6#   $��25(�61   $��0q�6?   $��SemiBold"�6L   $
��0,25q�6b   ���	#DDB81C1C6p   55      �� 57      -   5        $ tarih��57      $��Sera İç Sıcaklık��6#   $��1��6>   $��20(�6N   $
��Left=�6\   $��Center=�6w   
�������$��DemiBold"�6�   $��	30,80,0,0q�6�   �� 58      -   5        $ ileri��58      $��Images/ileri.png��6#   $��1��6=   $��Right=�6M   $��Center=�6i   $��55��6�   $��45��6�    J� Opacity$	 0.7Q�6�   $��0,0,15,0q�6�   59      5:      5;      5<      5=      5>      