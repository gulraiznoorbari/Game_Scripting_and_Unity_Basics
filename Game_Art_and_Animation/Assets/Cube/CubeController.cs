using UnityEngine;
using DG.Tweening;

// Tweening:
public class CubeController : MonoBehaviour
{
    private Sequence _sequence;

    private void Update()
    {
        if (Input.GetKey(KeyCode.J)) {
            Jump();
        }
        else if (Input.GetKey(KeyCode.R)) {
            Rotate();
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            PlaySequence();
        }
    }
    private void Jump()
    {
        transform.DOJump(Vector3.zero, 2, 1, 1f);
    }

    private void Rotate()
    {
        transform.DORotate(new Vector3(0, 360, 0), 1, RotateMode.FastBeyond360);
    }

    private void PlaySequence()
    {
        _sequence?.Kill();

        _sequence = DOTween.Sequence()
            .AppendInterval(.25f)
            .Append(transform.DOJump(new Vector3(1, 0, 0), 2, 1, 1f))
            .Join(transform.DORotate(new Vector3(0, 360, 0), 1f, RotateMode.FastBeyond360))
            .AppendInterval(.25f)
            //.Join(transform.DOMoveX(2, 1f))
            .SetLoops(-1, LoopType.Yoyo);
    }
}
