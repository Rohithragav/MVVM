   M S B A M L   `   `   `  ����C  ?MVVMDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MVVMDemoMVVMDemo  5   	   #    MVVMDemo.UserRegistrationView   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      *	viewmodelclr-namespace:MVVMDemo    5   	     � Title$  Window1��5      $	��300��6   $��419.415��6"    � 	Resources 5         MVVMDemo.ViewModel   	ViewModel��%   &	          5	   
   6   5
      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��3��5   1   $��1��6>   ��6   �� *lines+ �� View 5      �� 5   
   .P�5      �� $
��Line��6    �� Width$ 30��6P    �� DisplayMemberBinding 6+   �� *Lno+6P   �� 5      $��Content��6&   $	 400��67   	 �� CellTemplate	 5      �� 5      .R�5   "   �� ��6,   �� *	Content+��6E   �� *color+5      5!      5"      5$      5%      5'      