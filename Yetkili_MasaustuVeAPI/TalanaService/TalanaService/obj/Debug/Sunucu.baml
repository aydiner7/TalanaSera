   M S B A M L   `   `   `  ����H  DTalanaService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TalanaServiceTalanaService  5   	       TalanaService.Sunucu   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   'localclr-namespace:TalanaService  5   	     � Title$  Sunucu��5	   	   $	��320��6   $��420.62��6%    � WindowState$ Normal=�64    � WindowStyle$
 None=�6I    � WindowStartupLocation$ CenterScreen=�6\   .��5
      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��389* �6   .+�5   
   �� $��50��6   $��0��6    $	��Top=�6-   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $��Sunucu Ayar Paneli��6   
�������$��0��6@   $
��Left=�6M   $	��Top=�6h   $��20(�6�   $��20 6 0 0q�6�   �� 5   
   -   5        $��0��5      $	��Top=�6   $��Right=�65   $��10q�6Q   $��30��6]   $��30��6�   $��Assets/PencereKapat.png��6�   	 � Cursor$
	 Hand��6�   �� 5   
   $	��235��6   $	��top=�6"   $��15q�6:   $��1��6F   .+�5      �� -   5        
 ��Name$
 	Sunucutxt��5      $
��0,10q�6)   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Sunucu��67    %  !MaterialDesignFloatingHintTextBox#��[  6_   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $
 Kaditxt��5      $
��0,10q�6'   $ Kullanici Adı��65   #��[  6d   $��Champagne & Limousines)�6�   $��18(�6�   G� 5      -   5         G�Name$ sifretxt��5      $
��0,10q�6,   $ Şifre��6:    ) %MaterialDesignFloatingHintPasswordBox#��[ 6a   $��Champagne & Limousines)�6�   $��18(�6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5         ��Name$ TestBtn��5   B   $	��150��6   $��Right=�6%   $��Center=�6i   $��Test Et��6�   $��0,0,30,0q�6�   �� 5       -   5        $ 	KaydetBtn��5    B   $	��150��6   $��Right=�6%   $��Center=�6m   $��Kaydet��6�   5!      5"      5#      5$      