   M S B A M L   `   `   `  ����R  NГрафик курса, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:График_курсаГрафик_курса  5   	   (    "График_курса.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:График_курса     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
���   � J� OpacityMask
 �   ����	#FF020101.��5	      � $��10q�6   
���   � � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� -   5         ��Name$ CurrencyBox��5      $	��100��6,   $��0,0,10,0q�68   ��5      �� 5       �� EndPoint$	 0,1&�6*   .��5      �  � Color$ 	#FFF0F0F0��6'   � 5      $ 	#FFE2E2E2��6'    � Offset$ 1Q�69   5      .@�5      �� $	��USD��6    �� 
IsSelected$
 True��6-   �� 5      $	��EUR��6   5      �� 5      -   5        $ 	PeriodBox��5      $	��120��6*   ��5      �� 5      $	 0,1&�6*   .��5      � $ 	#FFF0F0F0��6'   � 5       $ 	#FFEDEDED��6'   $ 1Q�69   � 5!      $ 	#FFEFEFEF��6'   $ 0.317Q�69   5"      .@�5$      �� $��
Месяц��6   $
 True��6/   �� 5%      $��Полгода��6   �� 5&      $��Год��6   5'      �� 5)      -   5        $%��Построить график��5)      $��10,0,0,0q�6J   
�������6\   5*      �� 5,   
   -   5        	 ��Name$	 ChartCanvas��5,      $��1��6&   
���   �63   �� 5.   
   -   5        
 ��Name$
 AverageText��5.      $��2��6)   $��16(�66   $��0,10,0,0q�6D   $
��Bold"�6V   
�������6h   5/      50      