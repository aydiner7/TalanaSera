   M S B A M L   `   `   `  ����H  DTalanaService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TalanaService.PencerelerTalanaService.Pencereler  5   	   ,    &TalanaService.Pencereler.KullaniciEkle   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   2local&clr-namespace:TalanaService.Pencereler  5   	     � Title$  KullaniciEkle��5	   	   $��472.992��6   $��430.474��60    � WindowState$ Normal=�6@    � WindowStyle$
 None=�6U    � WindowStartupLocation$ CenterScreen=�6h   .��5
      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��389* �6   .+�5   
   �� $��50��6   $��0��6    $	��Top=�6-   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $��Kullanıcı Ekle��6   
�������$��0��6<   $
��Left=�6I   $	��Top=�6d   $��20(�6|   $��20 6 0 0q�6�   �� 5   
   -   5        $��0��5      $	��Top=�6   $��Right=�65   $��10q�6Q   $��30��6]   $��30��6�   $6��0/TalanaService;Component/Assets/PencereKapat.png��6�   	 � Cursor$
	 Hand��6�   �� 5   
   $��1��6   .��5      �� $��20,0,0,0q�6   .+�5      �� -   5        $	��100��5   P   $	��100��6]   
 �� RadiusX$
 30��6i    �� RadiusY$ 30��6v   $��Center=�6�   $��0,20,0,0q�6�   ��5      �� 5      -   5        kullaniciResim�� �� ImageSource$0 */TalanaService;Component/Assets/profil.jpg��5   =   5!      �� 5"      -   5         ��Name$ Kodtxt��5"      $
��0,10q�6*   {�.  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Kullanıcı kodu��6J    %  !MaterialDesignFloatingHintTextBox#��[  6z   $��Champagne & Limousines)�6�   $��18(�6�   �� 5#      -   5        $ Adtxt��5#      $
��0,10q�6)   $ Kullanıcı Adı��67   #��[  6f   $��Champagne & Limousines)�6�   $��18(�6�   �� 5$      -   5        $ Sadtxt��5$      $
��0,10q�6*   $ Kullanici Soyadı��68   #��[  6j   $��Champagne & Limousines)�6�   $��18(�6�   G� 5%      -   5         G�Name$ sifretxt��5%      $
��0,10q�60   $ Şifre��6>    ) %MaterialDesignFloatingHintPasswordBox#��[ 6e   $��Champagne & Limousines)�6�   $��18(�6�   �� 5&      -   5         ��Name$ 	KaydetBtn��5&   B   $	��150��6   $��Right=�6%   $��Center=�6m   $��Kullanıcı Oluştur��6�   $��0,0,30,0q�6�   5(      5)      5*      5+      