   M S B A M L   `   `   `  ����E  AWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WeatherApp.ViewsWeatherApp.Views  5      (    "WeatherApp.Views.WeatherScreenView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      *localclr-namespace:WeatherApp.Views  5      .��5
      � -   5          �Name$
  main��5
      ��5   
   �� 5       �� ImageSource$_ Yhttps://t3.ftcdn.net/jpg/02/28/37/48/360_F_228374822_swvpReqovxC0uM7awKLmwqEO8lyC0nki.jpg��6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��2��6    �� CornerRadius$ 25��5      $��20q�5      
�������$	��310��5      $	��400��5      $	��150��5      $	��250��5      ._�5      �� 
�������$��-2q�5       .+�5!      �� -   5         ��Name$
 City��5!      $
��City��6*   
������$��40(�5#      $
��Bold"�5$       �� TextAlignment$ Center=�5%      �� 5&      -   5        $ Country��5&      $��Country��6-   
��� ���$��20(�5(      $��SemiBold"�5)      $ Center=�5*      �� 5+      $	��100��5,      $	��100��5-      $��Center=�5.      ��5+      �� *ConditionImg+5.      �� 5/      -   5        $
 Temp��5/      $��Temperature��6*   
��� ���$��25(�51      $��SemiBold"�52      $ Center=�53      �� 54      -   5        $ Description��54      $��Description��61   
������$��30(�56      $��SemiBold"�57      $ Center=�58      �� 59      -   5        $ AvgTemp��59      $��Min-Max Temperature��6-   
��� ���$��20(�5;      $��
ExtraLight"�5<      $ Center=�5=      5>      5?      �� 5B   
   $��1��6   $ 15��5C      $��7q�5D      
�������$	��310��5F      $��60��5G      $	��150��5H      $��40��5I      $��0, 0, 0, -15q�5J      ._�5K      ��  �� Orientation$ 
Horizontal=�6   
�������$��60��5M      $��40��5N      $��Stretch=�5O      $��-1q�5P      .+�5Q      �� -   5         ��Name$ 	InputCity��5Q         TextBoxWithoutBorder#���   5R      
������$��30��5T      $	��250��5U      $��20(�5V      $��SemiBold"�5W      �� 5X      -   5        	 ��Name$	 LoadWeatherByCity��5X        ButtonRounded#���  5Y      $��40��5Z      $��40��5[      .��5\      �� $c��]https://img.freepik.com/premium-photo/3d-icon-online-search-illustration_738723-30.jpg?w=2000��6   5]      5^      5_      �� 5a   
   $��1��6   $��1��5b      $ 15��5c      $��20q�5d      
�������$	��310��5f      $	��310��5g      $	��150��5h      $	��200��5i      $��0, -10, 0, 0q�5j      ._�5k      �� 
�������$��-1q�5l      .+�5m      �� $	��100��5n      $	��100��5o      ��5m      �� *WindspeedImg+5o      �� 5p      -	   5        $ 	Windspeed��5p      $��
Wind speed��6/   
������$��25(�5r      $��SemiBold"�5s      $ Center=�5t      �� 5u      $	��100��5v      $��0, 30, 0, 0q�5w      $��Disabled=�5x      ��5u      �� *WeatherDays+��5y      �� 5z      .R�5{      A� 
 A� Rows$
 1��6*   5|      ��5~      �� 5      .R�5�      �� .+�5�   "   �� 
������$��12(�5�   ,   $��SemiBold"�5�   ,   $ Center=�5�   ,   ��5�   ,   �� *Date+5�   ,   �� 5�   "   $��50��5�   (   $��50��5�   (   ��5�   (   �� *ConditionImg+5�   (   �� 5�   "   
��� ���$��20(�5�   ,   $��SemiBold"�5�   ,   $ Center=�5�   ,   ��5�   ,   �� *AvgTemperature+5�   ,   5�      5�      5�      5�      5�      �� 5�   
   -
   5         ��Name$ LoadingIcon��5�      $y�Hidden=�5�      $��2��5�      $��2��5�      ��5�      �� 5�      $_ Yhttps://t3.ftcdn.net/jpg/02/28/37/48/360_F_228374822_swvpReqovxC0uM7awKLmwqEO8lyC0nki.jpg��6   .+�5�      �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$N Hhttps://cdn.dribbble.com/users/2973561/screenshots/5757826/loading__.gif��6   $	��100��5�      $	��100��5�      $��Center=�5�      $��Center=�5�       �� Left$	 420��61   
 �� Top$	 175��6C   5�      5�      5�      