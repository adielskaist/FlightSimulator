   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   J FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views 5   	       FlightSimulator.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @SystemGesture&clr-namespace:System;assembly=mscorlib     5   	   5Views#clr-namespace:FlightSimulator.Views     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5         Flight Control �� 
TargetType �� Property �� Value��%�   &	        '�� &     '�� y     ��5   
   Flight Control��6F   �� 5   
   " ��6   .�5      ��  � ��$ Comic sans MS)�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ Comic sans MS)�6+   5      5      .��5      (� .��5      � $	��450��6   $	��800��6    � ColumnDefinitions 5   
   �� 5      $
��192* �6   �� 5      $
��205* �6   .+�5   
   (� $��48,78,14,52q�6   .��5      � $	��500��6   $	��500��6   .+�5      '  !FlightSimulator.Views.FlightBoard  5      5       �� 5"   
   $
��Left=�6   $	��350��60   $	��350��6=   $��	32,24,0,0q�6I   $	��Top=�6\   $��1��6t   .@�5#      �� $��Manual��6   $��-2,-2,-7.571,-0.429q�6&   .��5$      )  #FlightSimulator.Views.ManualControl  5%      �� 5&      $��
Auto Pilot��6   $��8.571,-2,-13.857,0q�6*   .��5'      � 
�������$��0,1,7,4.429q�6*   .+�5(      %  FlightSimulator.Views.AutoPilot  6(   5)      5*      5+      �� 5,   
   -   5         ��Name$ Settings��5,      $��Settings��6#   $��70��66   $��20��6A   $
��Left=�5-      $	��Top=�6,   $��
230,30,0,0q�6D   ��6X   �� *SettingsCommand+�� 5.   
   -   5        $ Connect��5.      $��Connect��6"   $��70��64   $��20��6?   $
��Left=�5/      $	��Top=�6,   $��
150,30,0,0q�6D   ��6X   �� *ConnectCommand+�� 50      -   5        $ 
Disconnect��50      $��
Disconnect��6)   $��70��6>   $��20��6I   $
��Left=�51      $	��Top=�6,   $��	70,30,0,0q�6D   ��6W   �� *DisconnectCommand+52      53      54      