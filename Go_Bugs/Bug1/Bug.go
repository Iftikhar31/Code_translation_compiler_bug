package main

type Set[E comparable] map[E]struct{}

func NewSet[E comparable]() Set[E] { return nil }

func (Set[E]) m(E) Set[E] { return nil }

func Map[R any, RS interface{ m(R) RS }](_ func() R, toFn func() RS) RS {
	return toFn()
}

func main() {
	Map(func() int { return 0 }, NewSet)
}
