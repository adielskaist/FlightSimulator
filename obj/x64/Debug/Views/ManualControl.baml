   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5      )    #FlightSimulator.Views.ManualControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FlightSimulator.Views     5        � 	Resources  5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ Comic sans MS)�6+   �� 5       � ��$ 20(�6)   �� 5       � ��
 �����6+   5      5      .��5      (� .��5      � $	��600��6   $	��600��6   .+�5   
   �� 
�������$	��100��6'   $��30��63   $	��top=�6?   $��0,80,0,0q�6W   ←aileron→6t   �� 5   
   
�������$	��100��6'   $��30��63   $��Bottom=�6?   $��0,0,0,40q�6Z   ←rudder→6v   �� 5   
   
�������$	��110��6'   $��30��63   $
��Left=�6?   $��40,0,0,0q�6Z   $��←throttle→��6l    � LayoutTransform 5      �� 5       �� Angle$ 90Q�6"   6/   5      �� 5   
   
�������$	��110��6'   $��30��63   $��Right=�6?   $��0,0,80,0q�6[   $��←elevator→��6m    5      �� 5      $ 90Q�6"   6/   5      �� 5       -   5         ��Name$ RudderSlider��5       $	��340��6+   $��Bottom=�67   $��0,0,0,80q�6R    � Maximum$ 1Q�6d    � Minimum$ -1Q�6p   	 � Value	 6}   �� *Rudder+�� 5!      -   5        $ ThrottleSlider��5!      $	��340��6-   
 �� Orientation$
 Vertical=�6:   $
��Left=�6Q   $��80,0,0,0q�6l   $ 0Q�6~   $ 1Q�6�   	 6�   �� *
Throttle+$   FlightSimulator.Views.Joystick  5"   
   -   5          Name$ joystick��5"         Aileron 6+   �� *	Alieron+ �� Mode$ OneWayToSource=�   Elevator 5#      �� *
Elevator+$ OneWayToSource=�5%      �� 5&      -   5         ��Name$ rudderIndicaror��5&      $��50��6y   $��30��6�   $��Bottom=�6�   $��Right=�6�   $��	0,0,70,75q�6�   ��61   ��  �� ElementName$ RudderSlider�� �� Path$ Value� �� StringFormat$	 0.0��6�   �� 5'      -   5        $ throttleIndicaror��5'      $��50��6}   $��30��6�   $	��Top=�6�   $
��Left=�6�   $��	73,90,0,0q�6�   ��63   �� $ ThrottleSlider��$ Value�$	 0.0��6�   �� 5(   
   -   5        $ ailronIndicaror��5(      $��50��6s   $��30��6~   $	��Top=�6�   $��Right=�6�   $��
0,90,120,0q�6�   ��6-   �� $ joystick��$ Aileron�$	 0.0��6�   �� 5)   
   -   5        $ elevatorIndicaror��5)      $��50��6w   $��30��6�   $	��Top=�6�   $��Right=�6�   $��
0,120,90,0q�6�   ��60   �� $ joystick��$ Elevator�$	 0.0�� 5*      �� 5+      $ 90Q�6"   5-      5.      5/      50      