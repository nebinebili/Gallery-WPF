   M S B A M L   `   `   `  ����G  CImageGallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ImageGalleryImageGallery  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6{       ImageGallery.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ImageGallery     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  62   0sys&clr-namespace:System;assembly=mscorlib  6{      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��740��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5        	imageSize��%%   &	       X�5   
   250Q�6,   5      .��5      � ��5   
   �� 5       �� ImageSource$ Images/sea1.png��6   5      .+�5   
   ��  �� CornerRadius$ 20��5       
�������$	��630��5"      $	��830��5#      ._�5%      � -   5        $
��grid��5(   #   $	��619��5&      $	��819��5'      
������� � RowDefinitions 5+      �� 5,      $��1* �6$   62   �� 5-      $��7* �6$   62   .+�51      � $��0��6   
�������.+�54      o�  o� 
IsMainMenu . .@�56      m� $��_File��57      .@�58      m� $	��New��59      5:      m� 5;      $
��Open��5<      5=      m� 5>      $
��Save��5?      	 m� Icon	 5@      0  *MaterialDesignThemes.Wpf.PackIconExtension  
   Kind$
 ContentSave=�6S   m� 5A      $��	Save As..��6'   m� 5B      $
��Exit��5C   !   	 5D   !     $
 	ExitToApp=�5F      m� 5G      $��_Edit��5H      .@�5I      m� -   5        $��Add File��5I   '   69   m� 5J      $��
Add Folder��6'   5L      m� 5M      $
��View��5N      .@�5O      m� -   5        $��Small��5O   '   66   m� 5P      -   5        $��Medium��5P   '   67   m� 5Q      -   5        $��Large��5Q   '   66   5R      m� 5S      $��About��5T      .@�5U      m� $��About��6'   5V      5W      �� 5Y      $��25(�5Z      $��Images��5[      $��
350,20,0,0q�5\      5^      5`      � 5c      $��1��6   .+�5e      �� -   5         ��Name$ listbox_image��5f      $��0q�5g      |�.  ��5h      �� *
Pictures+��5l      �� 5m      .R�5n   "   �  � Orientation$ 
Horizontal=�5o   "   $
��auto��5p   "   $	��810��5q   "   $��0,20,0,0q�5r   "   5t   #   5v      ��5z      �� 5{      .R�5}   "   �� $
��Fill=�5�   $   #���  5�   $   #���  5�   $   $��20,0,0,0q�5�   $   ��5   $   �� *ImageSource+5�   #   5�      5�      5�      5�      5�       � 5�      -   5          �Name$
 Main��5�        � NavigationUIVisibility$ Hidden=�6    6C   5�      5�      