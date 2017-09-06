import sys
sys.path.append(r"C:\Program Files (x86)\Python27\Lib")
import clr
import os
import pickle
clr.AddReference('System.Windows.Forms')
from operator import itemgetter


def makeHSTable(name, score):
    highScoresFilename = 'highScores.dat'
    scores = []
    # checks if file to save scores exists, if not, creates one
    if os.path.exists(highScoresFilename):
        with open(highScoresFilename,'rb') as rs: 
            scores = pickle.load(rs)

    highScore = name, score
    scores.append(highScore)
            
    # update score table
    with open(highScoresFilename,'wb') as ws:
        pickle.dump(scores, ws)
               
    # re-open score table and sort so that highest score is first, only 10 entries
    with open(highScoresFilename,'rb') as rs:
       scores = pickle.load(rs)
       scores = sorted(scores, key=itemgetter(1), reverse=True)[:10]

    return scores


#print(makeHSTable("genericName", 5))
#raw_input()
       