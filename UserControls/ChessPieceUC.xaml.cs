﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessAI.ViewModel;

namespace ChessAI.UserControls {
	/// <summary>
	/// Interaction logic for ChessPiece.xaml
	/// </summary>
	public partial class ChessPiece : UserControl {
		public ChessPiece() {
			InitializeComponent();
		}

		private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
			if (DataContext is ChessPieceViewModel) {
				ChessPieceViewModel tempVPVM = (ChessPieceViewModel)DataContext;
				PieceImg.Source = new BitmapImage(new Uri(tempVPVM.ResourceURI, UriKind.Relative));
			}
		}
	}
}
