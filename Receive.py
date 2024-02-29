from socket import *
import os


## UDP受信クラス
class udprecv():
    def __init__(self):

        #研究室
        #SrcIP = "192.168.11.33"                        # 受信元IP

        #テザリング
        #SrcIP = "172.20.10.8"                        # 受信元IP

        #テザリング GamePro
        SrcIP = "172.20.10.10"                        # 受信元IP

        SrcPort = 55998                                  # 受信元ポート番号
        
        self.SrcAddr = (SrcIP, SrcPort)                 # アドレスをtupleに格納

        self.BUFSIZE = 1024                             # バッファサイズ指定
        self.udpServSock = socket(AF_INET, SOCK_DGRAM)  # ソケット作成
        self.udpServSock.bind(self.SrcAddr)             # 受信元アドレスでバインド


    def recv(self):
            
        while True:                                     # 常に受信待ち

            data, addr = self.udpServSock.recvfrom(self.BUFSIZE)
                                                        # 受信
            print(data.decode(), addr)                  # 受信データと送信アドレス表示


            print("ホンマにここでループしてんのか？")
            print(data.decode())
        

udp = udprecv()     # クラス呼び出し
udp.recv()          # 関数実行
