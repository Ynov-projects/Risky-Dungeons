using UnityEngine;
using Mirror;
using System.Net;

public class CustomNetworkHUD : MonoBehaviour
{
    private NetworkManager manager;

    void Awake()
    {
        // Récupère le NetworkManager
        manager = GetComponent<NetworkManager>();
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 300, 200));

        // Si le serveur est actif, affiche les informations d'hôte
        if (NetworkServer.active)
        {
            GUILayout.Label("Server: active");
            GUILayout.Label("Host IP: " + GetLocalIPAddress());

            if (GUILayout.Button("Stop Host"))
            {
                manager.StopHost();
            }
        }
        // Si le client est connecté mais n'est pas l'hôte
        else if (NetworkClient.isConnected)
        {
            GUILayout.Label("Client: connected");

            if (GUILayout.Button("Stop Client"))
            {
                manager.StopClient();
            }
        }
        // Affiche les boutons pour démarrer le serveur ou rejoindre en tant que client
        else
        {
            if (GUILayout.Button("Start Host"))
            {
                manager.StartHost();
            }

            if (GUILayout.Button("Start Client"))
            {
                manager.StartClient();
            }

            GUILayout.Label("Enter IP to Connect:");
            manager.networkAddress = GUILayout.TextField(manager.networkAddress);

            if (GUILayout.Button("Connect as Client"))
            {
                manager.StartClient();
            }
        }

        GUILayout.EndArea();
    }

    // Méthode pour obtenir l'adresse IP locale
    private string GetLocalIPAddress()
    {
        foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
        {
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        return "IP non trouvée";
    }
}
