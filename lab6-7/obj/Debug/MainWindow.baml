   M S B A M L   `   `   `  ����A  =lab6-7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab6_7lab6_7  5   	       lab6_7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:lab6_7     5   	   -   5          �Name$  MainWindow1��5   	    � Title$ Grocery Store��5   	   $	��610��6   $	��900��6,   $	��900��68   $	��600��6G    � Icon$$ iconfinder_Harvest_2998126.ico��6W    � Cursor$ No��6}    � 	Resources 5	         
UserCursor �� 
TargetType  menuButtons �� Property �� Value  centeredText��%�  &	        &	 %     &	      ��5
   
   D:\banana.cur��63   �� 5   
   " ��6   .�5      ��  � ��$ Arial Black)�6+   6A   �� 5       � �� �#99aab56=   �� 5       � �� �#2c2f336=   �� 5       � ��$ 0q�60   6<   �� 5       � ��$ 30��6'   64   5      �� 5   
   " ��6   .�5      ��  �@��TextAlignment$ Center=�6.   6?   �� 5       � �� �#99aab56=   �� 5       � ��$ 
ArialBlack)�6+   6@   5      5      .��5      � ���#23272a# [  6     � RowDefinitions 5   
   �� 5      $
��230* �6   �� 5      $	��29* �6   �� 5      $	��31* �6   	 � ColumnDefinitions	 5   
   �� 5      $
��112* �6   �� 5       $
��335* �6   .+�5"   
   �� $��0,0,3,0q�6   ���#2c2f33$��	0,0,18,-4q�6A   $��3��6T   $��0��6e   ._�5#      �� ���#23272a$��0��6.   $��0��6>   $��3��6K   $��0,0,-23.8,0q�6\   .+�5$      �� -   5        
 ��Name$
 	LabelMenu��5$      $
��15pt(�6/    �� Padding$ 14q�6?   $��50��6L   #��[ 6X   $
��Bold"�6~     menu#���  6�   6�   �� 5%      -   5         ��Name$ ButtonOutputBasket��5%      #��[ 65   $��	0,10,0,20q�6Z   .��5&      �� $
��Wrap=�6      OutputBasket#���  64   6\   5'      �� 5(      -   5        $ ButtonEditBasket��5(      #��[ 63   $��0,0,0,20q�6X   .��5)      �� $
��Wrap=�6      
EditBasket#���  64   6Z   5*      �� 5+      -   5        $ ButtonAddGood��5+      #��[ 60   .��5,      �� $
��Wrap=�6      AddGood#���  64   6W   5-      �� 5.      -   5        $ ButtonEN��5.      $��50��6+   $��50��67   $��
-80,20,0,0q�6B   
������ $��0q�6o   
 � Tag$ ru-RU��6�   .��5/      �� $"��united-states-of-america.png��6   6D   50      �� 51      -   5        $ ButtonRU��51      $��50��6+   $��50��67   $��
80,-50,0 0q�6B   
������ $��0q�6o   .��52      �� $��
russia.png��6   $ en-US��60   6>   53      54      55      �� 56   
   $��0��6   $��1��6%   $��0,0,3,62q�62   $��2��6D   .+�57      �� -   5        $ ButtonExitApplication��57      $
��auto��58      $��50��59      $��0,4,0,0q�5:      ���#EF5B51���#23272a  
ButtonExit#���  5=      $
��Bold"�5>      $��16(�5?      6I   5@      �� 5B   
   $��1��6   ���#23272a$��
3,0,0.6,-4q�6:   $��3��6N   .+�5C      �� $��shopping-basket.png��6   $	��260��61   $��0,80,0,0q�6>   �� 5D      #��[ 6   $
��24pt(�6J   $��50��6Z   $��0,50,0,0q�6f     Welcome#���  6x   6�   �� 5E      #��[ 6   $
��18pt(�6J   $��40��6Z   $��	0,-10,0,0q�6f    	 GoodBuys#��� 	 6y   6�   5F      5G      5H      