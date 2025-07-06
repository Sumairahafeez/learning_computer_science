import numpy as np
import matplotlib.pyplot as plt
X = np.linspace(0, np.pi, 256, endpoint=True)
Y = np.cos(X)
fig,alt = plt.subplots()
# fig,alt2 = plt.imshow(X)
alt.imshow(X)
# alt.inset_axes([0.5, 0.5, 0.4, 0.4])
plt.show()