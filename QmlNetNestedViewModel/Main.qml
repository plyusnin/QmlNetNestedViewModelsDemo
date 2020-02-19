import QtQuick 2.9
import QtQuick.Layouts 1.3
import QtQuick.Controls 2.3
import QtQuick.Controls.Material 2.1
import Features 1.0

ApplicationWindow {
    id: window
    width: 360
    height: 520
    visible: true
    title: "Qml.Net"
    
    MainViewModel {
        id: viewModel
    }
    
    Column {
        anchors.centerIn: parent
        Text {
            text: viewModel.mainText
        }
        Text {
            text: viewModel.child.text
        }
    }
}
