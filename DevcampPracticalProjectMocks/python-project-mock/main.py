from app import app

import os

if __name__ == '__main__':

    NET_INTERFACE = '0.0.0.0'
    HTTP_PORT = int(os.environ.get('HTTP_PORT', default=5555))
    app.run(host=NET_INTERFACE, port=HTTP_PORT)
