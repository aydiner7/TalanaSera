   M S B A M L   `   `   `  ����H  DTalanaService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TalanaService.PencerelerTalanaService.Pencereler  5   	   '    !TalanaService.Pencereler.TankEkle   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   2local&clr-namespace:TalanaService.Pencereler  5   	     � Title$  TankEkle��5	   	   $��300.547��6   $��430.474��6+    � WindowState$ Normal=�6;    � WindowStyle$
 None=�6P    � WindowStartupLocation$ CenterScreen=�6c   .��5
      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��389* �6   .+�5   
   �� $��50��6   $��0��6    $	��Top=�6-   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $��	Tank Ekle��6   
�������$��0��67   $
��Left=�6D   $	��Top=�6_   $��20(�6w   $��20 6 0 0q�6�   �� 5   
   -   5        $��0��5      $	��Top=�6   $��Right=�65   $��10q�6Q   $��30��6]   $��30��6�   $6��0/TalanaService;Component/Assets/PencereKapat.png��6�   	 � Cursor$
	 Hand��6�   �� 5   
   $��1��6   .��5      �� $��	20,20,0,0q�6   .+�5      �� -   5        
 ��Name$
 Ilaclar��5       �� SelectedIndex$ 0��6,   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��6>   )  #MaterialDesignThemes.Wpf.HintAssist   
IsFloating . $��Stretch=�6�   $	��277��6�   �� 5      -   5         ��Name$ Adtxt��5      $
��0,10q�6)      Hint$ Tank Kapasitesi (litre)��67    %  !MaterialDesignFloatingHintTextBox#��[  6p   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ Sadtxt��5      $
��0,10q�6*   $ İlaç Miktarı(litre)��68   #��[  6m   $��Champagne & Limousines)�6�   $��18(�6�   �� 5       -   5         ��Name$ 	KaydetBtn��5    B   $	��150��6   $��Right=�6%   $��Center=�6m   $��Tank Oluştur��6�   $��0,0,30,0q�6�   5"      5#      5$      5%      